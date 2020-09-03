using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Media;
using System.Drawing.Drawing2D;




namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        char[] buffer = new char[7];
        string indata;
        Timer Timer1;
        Timer Timer2;
        Timer Timer3;
        Timer T_delay;
        Timer Timer4;
        Timer Timer5;
        decimal alfa_inicial;
        decimal alfa_minimo;
        int alfa_inicial_int;
        int alfa_minimo_int;
        int tempo_acionamento;
        int tempo_desaceleração;
        int margem_erro;
        int angulo;
        double angulo_real_1;
        double angulo_real_2;
        double vrms;
        int TMR1_real;
        int angulo_real_H;
        int angulo_real_L;
        int anal_H;
        int valor_anal;
        int angulo_min;
        bool ligado;
        bool conectado;
        bool configurado;
        bool erro_conexao;
        bool teste_recebido;
        bool envio_ok = false;
        bool manual = false;
        bool falta_energia = false;
        int TMR1HX;
        int TMR1LX;
        int TMR0;
        int ANGMNH;
        int ANGMNL;
        double angulo_calculo = 0;

        public Form1()
        {
            InitializeComponent();
            Timer1 = new Timer();
            Timer2 = new Timer();
            Timer3 = new Timer();
            T_delay = new Timer();
            Timer4 = new Timer();
            Timer5 = new Timer();
            PORTA.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            Timer1.Tick += new EventHandler(Interrupt_timer1);
            Timer2.Tick += new EventHandler(Interrupt_timer2);
            Timer3.Tick += new EventHandler(Interrupt_timer3);
            Timer4.Tick += new EventHandler(Interrupt_timer4);
            T_delay.Tick += new EventHandler(Interrupt_t_delay);
            try
            {
                if (!PORTA.IsOpen)
                    PORTA.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na porta: " + ex.Message, "Erro!");
            }

            Timer1.Interval = 100;
            Timer1.Enabled = true; // Desabilita o Timer
            Timer1.Start();
            Timer2.Interval = 2000;
            Timer2.Enabled = true;
            Timer2.Start();
            Timer3.Interval = 1000;
            Timer3.Enabled = true;
            Timer3.Start();
            Timer4.Interval = 100;
            Timer4.Enabled = true;
            Timer4.Start();
            T_delay.Interval = 100;
            T_delay.Enabled = true;
            T_delay.Stop();
            Timer5.Interval = 10;
            Timer5.Enabled = false;
            Timer5.Stop();
            //PORTA.Write("testexx");
           //timerMoveSprite.Stop(); // Também desabilita o Timer
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Alexandre\Documents\sofstarter\Olá, Irineu!.wav");
            //simpleSound.Play();
            enviar("testein");
        }


        public void Interrupt_t_delay(object source, EventArgs e)
        {
            MessageBox.Show("chegoutimer");
        }


        public void Interrupt_timer1(object source, EventArgs e)
        {
            angulo_real_1 = (trackBar1.Value / 100.0);
            alfa.Text = (angulo_real_1.ToString("0.00") + "º");
            angulo_real_1 = (Math.PI / 180.0) * angulo_real_1;
            vrms = (220.0) * (1 - (angulo_real_1 / (Math.PI)) + (Math.Sin(2.0 * angulo_real_1) / (2.0 * Math.PI)));
            v_motor.Text = (vrms.ToString("0.00") + " V");
            if (manual && ligado)
            {
                tensao_real.Text = v_motor.Text;
                alfa_real.Text = alfa.Text;
                progressBar2.Value = (int) (vrms*100);
            }

        }

        public void Interrupt_timer2(object source, EventArgs e)
        {
                if (teste_recebido)
                {
                    if (!conectado)
                    {
                        conectado = true;
                        conect_lab.ForeColor = Color.Green;
                        conect_lab.Text = "Conectado";
                        MessageBox.Show("Dispositivo conectado", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    teste_recebido = false;
                    erro_conexao = false;
                    margem_erro = 0;
                    return;
                }
                else
                {
                    if (++margem_erro == 1)
                    {
                        margem_erro = 0;
                        conectado = false;
                        if (!erro_conexao)
                        {
                            erro_conexao = true;
                            conect_lab.Text = "Desconectado";
                            conect_lab.ForeColor = Color.Red;
                            groupBox4.Visible = false;
                            configurado = false;
                            config_lab.Text = "Desconfigurado";
                            config_lab.ForeColor = Color.Red;
                            lig_lab.Text = "Desativado";
                            lig_lab.ForeColor = Color.Red;
                            ligado = false;
                            MessageBox.Show("Erro de conexão", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        return;
                    }
                }
        }

        public void Interrupt_timer3(object source, EventArgs e)
        {
            if (PORTA.IsOpen)
            {
                try
                {
                    enviar("testexx");
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void Interrupt_timer4(object source, EventArgs e)
        {
            if (manual && ligado)
            {
                angulo = (int)(((65535.0 - ((41000.0 / 18000.0) * trackBar1.Value))));
                TMR1HX = (angulo >> 8);
                TMR1LX = (angulo & 0x00FF);
                enviar("ANGH" + TMR1HX.ToString("000"));
                enviar("ANGL" + TMR1LX.ToString("000"));
            }
        }

        
        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            indata = port.ReadExisting();
            try{
            if (indata[0] == 'A' && indata[1] == 'D' && indata[2] == 'H')
            {
                anal_H = Convert.ToInt16(indata[3].ToString() + indata[4].ToString() + indata[5].ToString());
                teste_recebido = true;
            }
            if (indata[0] == 'A' && indata[1] == 'D' && indata[2] == 'L' && ligado==true)
            {
                valor_anal = Convert.ToInt16(indata[3].ToString() + indata[4].ToString() + indata[5].ToString() + indata[6].ToString());
                if (progressBar3.InvokeRequired) progressBar3.BeginInvoke((MethodInvoker)delegate
                        {
                            progressBar3.Value = valor_anal;
                        });
                if (i_motor.InvokeRequired) i_motor.BeginInvoke((MethodInvoker)delegate
                {
                    if ((valor_anal * 1.9) < 1000)
                    {
                        i_motor.Text = ((valor_anal * 1.9).ToString("0.00") + " mA");
                    }
                    else
                    {
                        i_motor.Text = (((valor_anal * 1.9)/1000).ToString("0.00") + "A");
                    }
                    teste_recebido = true;
                });

            }
            if (indata[0] == 'S' && indata[1] == 'T' && indata[2] == 'A' && indata[3] == 'T' && indata[4] == 'U' && indata[5] == 'S')
            {
                switch (indata[6])
                {
                    case '0': //desligado
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Desligado";
                            status.ForeColor = Color.Black;
                            ligado = false;
                            lig_lab.Text = "Desativado";
                            lig_lab.ForeColor = Color.Red;
                            falta_energia = false;
                            progressBar2.Value = 0;
                            progressBar3.Value = 0;
                            alfa_real.Text = "???";
                            tensao_real.Text = "???";
                            i_motor.Text = "???";
                            Timer5.Enabled = false;
                            Timer5.Stop();
                        });
                        break;
                    case '1': //OK
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "OK";
                            status.ForeColor = Color.Green;
                        });
                        break;
                    case '2': //Realimentação
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Realimentação";
                            status.ForeColor = Color.Orange;
                        });
                        break;
                    case '3': //Sobrecorrente
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Sobrecorrente";
                            status.ForeColor = Color.Red;
                            ligado = false;
                            lig_lab.Text = "Desativado";
                            lig_lab.ForeColor = Color.Red;
                            alfa_real.Text = "???";
                            tensao_real.Text = "???";
                            i_motor.Text = "???";
                            progressBar2.Value = 0;
                            progressBar3.Value = 0;
                        });
                        break;
                    case '4': //Corrente elevada
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Corrente elevada!";
                            status.ForeColor = Color.Orange;
                        });
                        break;
                    case '5': //falta de energia
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Falta de energia";
                            status.ForeColor = Color.Red;
                            ligado = false;
                            lig_lab.Text = "Desativado";
                            lig_lab.ForeColor = Color.Red;
                            falta_energia = true;
                            alfa_real.Text = "???";
                            tensao_real.Text = "???";
                            i_motor.Text = "???";
                            progressBar2.Value = 0;
                            progressBar3.Value = 0;
                            MessageBox.Show("Não há fornencimento de energia.", "Erro - Problema na rede elétrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                        break;
                    case '6': //energia restaurada
                        if (status.InvokeRequired) status.BeginInvoke((MethodInvoker)delegate
                        {
                            status.Text = "Desligado";
                            status.ForeColor = Color.Black;
                            falta_energia = false;
                            MessageBox.Show("Energia restaurada", "Rede elétrica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                        break;
                    case '7': //ligou
                        if (lig_lab.InvokeRequired) lig_lab.BeginInvoke((MethodInvoker)delegate
                        {
                            lig_lab.Text = "Ativado";
                            lig_lab.ForeColor = Color.Green;
                            Timer5.Enabled = false;
                            Timer5.Stop();
                            ligado = true;
                        });
                        break;
                }
                teste_recebido = true;
            }
            if (indata[0] == 'T' && indata[1] == '1' && indata[2] == 'H')
            {
                angulo_real_H = Convert.ToInt16(indata[3] + indata[4] + indata[5] + indata[6] + indata[7] + indata[8] + indata[9] + indata[10]);
                teste_recebido = true;
            }
            if (indata[0] == 'o' && indata[1] == 'i' && indata[2] == 'q')
            {
                MessageBox.Show("Recebeu");
                teste_recebido = true;
            }
            if (indata[0] == 'T' && indata[1] == '1' && indata[2] == 'L')
            {
                angulo_real_L = Convert.ToInt16(indata[3] + indata[4] + indata[5] + indata[6] + indata[7] + indata[8] + indata[9] + indata[10]);
                teste_recebido = true;
            }
            if (indata[0] == 't' && indata[1] == 'e' && indata[2] == 's' && indata[3] == 't' && indata[4] == 'e' && indata[5] == 'o' && indata[6] == 'k')
            {
                teste_recebido = true;
            }

            if (indata[0] == 'l' && indata[1] == 'i' && indata[2] == 'g' && indata[3] == 'a' && indata[4] == 'd' && indata[5] == 'o' && indata[6] == 'x')
            {
                ligado = true;
                lig_lab.Text = "Ativando";
                lig_lab.ForeColor = Color.Teal;
                status.Text = "OK";
                status.ForeColor = Color.Green;
                teste_recebido = true;
            }

            if (indata[0] == 'e' && indata[1] == 'r' && indata[2] == 'r' && indata[3] == 'o' && indata[4] == 'l' && indata[5] == 'i' && indata[6] == 'g')
            {
                MessageBox.Show("Erro ao ligar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                teste_recebido = true;
                return;
            }

            if (indata[0] == 't' && indata[1] == 'e' && indata[2] == 's' && indata[3] == 't' && indata[4] == 'e' && indata[5] == 'c' && indata[6] == 'c')
            {
                teste_recebido = true;
                conectado = true;
                if (conect_lab.InvokeRequired) conect_lab.BeginInvoke((MethodInvoker)delegate
                {
                    conect_lab.ForeColor = Color.Green;
                    conect_lab.Text = "Conectado";
                });
                MessageBox.Show("Dispositivo conectado", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teste_recebido = false;
                erro_conexao = false;
                margem_erro = 0;
            }
            
            if (indata[0] == 'e' && indata[1] == 'n' && indata[2] == 'v' && indata[3] == 'i' && indata[4] == 'o' && indata[5] == 'o' && indata[6] == 'k')
            {
                envio_ok = true;
            }
            if (indata[0] == 'a' && indata[1] == 'l' && indata[2] == 'f' && indata[3] == 'H')
            {
                angulo_real_H = Convert.ToInt16(indata[4].ToString() + indata[5].ToString() + indata[6].ToString());
                teste_recebido = true;
            }

            if (indata[0] == 'a' && indata[1] == 'l' && indata[2] == 'f' && indata[3] == 'L' && ligado==true)
            {
                angulo_real_L = Convert.ToInt16(indata[4].ToString() + indata[5].ToString() + indata[6].ToString());
                TMR1_real = ((angulo_real_H * 256) + angulo_real_L);
                angulo_real_2 = (((65535.0 - TMR1_real) / (41000.0 / 18000.0)) / 100.0);
                
                angulo_real_2 = (Math.PI / 180.0) * angulo_real_2;
                vrms = (220.0) *(1 - (angulo_real_2 / (Math.PI)) + (Math.Sin(2.0 * angulo_real_2) / (2.0 * Math.PI)));
                if (tensao_real.InvokeRequired) tensao_real.BeginInvoke((MethodInvoker)delegate
                {
                    tensao_real.Text = (vrms.ToString("0.00") + " V");
                    if ((vrms * 100) >= 0)
                    {
                        progressBar2.Value = (int)(vrms * 100);
                    }
                });
                angulo_real_2 /= (Math.PI/180.0);
                if (alfa_real.InvokeRequired) alfa_real.BeginInvoke((MethodInvoker)delegate
                {
                    alfa_real.Text = (angulo_real_2.ToString("0.00") + "º");
                });
                teste_recebido = true;
            }
            if (indata[0] == 'c' && indata[1] == 'o' && indata[2] == 'n' && indata[3] == 'f' && indata[4] == 'i' && indata[5] == 'g' && indata[6] == 'c')
            {
                configurado = true;
                if (progressBar1.InvokeRequired) progressBar1.BeginInvoke((MethodInvoker)delegate
                    {
                        progressBar1.Value = 100;
                    });

                if (config_lab.InvokeRequired) config_lab.BeginInvoke((MethodInvoker)delegate
                    {
                        config_lab.Text = "Configurado";
                    });
                config_lab.ForeColor = Color.Green;
                if (alfa_i.InvokeRequired) alfa_i.BeginInvoke((MethodInvoker)delegate
                {
                    alfa_i.Text = alfa_inicial.ToString() + "º";
                });
                if (alfa_m.InvokeRequired) alfa_m.BeginInvoke((MethodInvoker)delegate
                {
                    alfa_m.Text = alfa_minimo.ToString() + "º";
                });
                if (t_d.InvokeRequired) t_d.BeginInvoke((MethodInvoker)delegate
                {
                    t_d.Text = (tempo_desaceleração.ToString() + " s");
                });
                if (t_ac.InvokeRequired) t_ac.BeginInvoke((MethodInvoker)delegate
                {
                    t_ac.Text = (tempo_acionamento.ToString() + " s");
                });
                if (!groupBox4.Visible)
                {
                    if (groupBox4.InvokeRequired) groupBox4.BeginInvoke((MethodInvoker)delegate
                        {
                            groupBox4.Visible = true;
                        });
                }
            }
            }
            catch (Exception)
            {

            }
            
        }

        private void enviar(string buffer)
        {
            char[] bufer = buffer.ToCharArray(0, 7);
            if (PORTA.IsOpen)
            {
                try
                {
                    PORTA.Write(bufer, 0, 7);
                }
                catch (Exception ex)
                {
                   
                }
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                MessageBox.Show("Computador e dispositivo estão desconectados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ligado)
            {
                MessageBox.Show("Desative o dispositivo antes de configurar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            alfa_inicial = (numericUpDown1.Value);
            alfa_minimo = (numericUpDown2.Value);
            alfa_inicial_int = (int)(alfa_inicial * 100);
            alfa_minimo_int = (int)(alfa_minimo * 100);
            
            if (alfa_inicial_int < alfa_minimo_int)
            {
                MessageBox.Show("Alfa inicial menor que alfa mínimo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            tempo_acionamento = (int)(numericUpDown3.Value);
            tempo_desaceleração = (int)(numericUpDown4.Value);
            angulo = (int)(((65535.0 - ((41000.0 / 18000.0) * alfa_inicial_int))));
            TMR1_real = angulo;
            angulo_min = (int)(((65535.0 - ((41000.0 / 18000.0) * alfa_minimo_int))));
            TMR1HX = (angulo >> 8);
            TMR1LX = (angulo & 0x00FF);
            ANGMNH = (int)(angulo_min >> 8);
            ANGMNL = (int)(angulo_min & 0x00FF);
            TMR0 = (int)(256 - (((double)tempo_acionamento / ((double)angulo_min - (double)angulo)) / (double)0.0000064));
            if (TMR0 > 255 || TMR0<=0)
            {
                MessageBox.Show("Valor de partida inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            enviar("TMR0"+TMR0.ToString("000"));
            while (!envio_ok) ;
            progressBar1.Value = 20;
            envio_ok = false;
            enviar("ANGH" + TMR1HX.ToString("000"));
            while (!envio_ok) ;
            progressBar1.Value = 40;
            envio_ok = false;
            enviar("ANGL" + TMR1LX.ToString("000"));
            while (!envio_ok) ;
            progressBar1.Value = 60;
            envio_ok = false;
            enviar("AMNH" + ANGMNH.ToString("000"));
            while (!envio_ok) ;
            progressBar1.Value = 80;
            envio_ok = false;
            enviar("AMNL" + ANGMNL.ToString("000"));
            while (!envio_ok) ;
            progressBar1.Value = 90;
            envio_ok = false;
            enviar("confgok");
        }
        
        public void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!PORTA.IsOpen)
            {
                try
                {
                    PORTA.Close();
                    PORTA.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na porta: " + ex.Message, "Erro!");
                }
            }
            if (PORTA.IsOpen)
            {
                enviarteste();
            }
        }



        public void enviarteste()
        {
            string buffer = "#testeox";
            char[] bufer = buffer.ToCharArray(0, 8);
            try
            {
                PORTA.Write(bufer, 0, 8);
            }
            catch (Exception ex)
            {
            }
        }

        private void liga_Click(object sender, EventArgs e)
        {
            if (falta_energia)
            {
                MessageBox.Show("Não há fornencimento de energia.", "Erro - Problema na rede elétrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (conectado && configurado)
            {
                TMR0 = (int)(256 - (((double)tempo_acionamento / ((double)angulo_min - (double)angulo)) / (double)0.0000064));
                enviar("TMR0" + TMR0.ToString("000"));
                enviar("ligarxx");
                lig_lab.Text = "Ativando";
                lig_lab.ForeColor = Color.Teal;
                ligado = true;
                status.Text = "OK";
                status.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Dispositivo desconectado e/ou desconfigurado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        

        private void desliga_Click(object sender, EventArgs e)
        {
            if (ligado)
            {

                TMR0 = (int)(256 - (((double)tempo_desaceleração / ((double)angulo_min - (double)angulo)) / (double)0.0000064));
                enviar("TMR0" + TMR0.ToString("000"));
                while (!envio_ok) ;
                envio_ok = false;
                enviar("desligx");
                lig_lab.Text = "Desativando";
                lig_lab.ForeColor = Color.Teal;
                Timer5.Enabled = true;
                Timer5.Start();
            }
            else
            {
                MessageBox.Show("Dispositivo já está desativado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PORTA.IsOpen)
            {
                PORTA.Write("#");
                enviar("emergex");
                ligado = false;
                lig_lab.Text = "Desativado";
                lig_lab.ForeColor = Color.Red;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                alfa_real.Text = "???";
                tensao_real.Text = "???";
                i_motor.Text = "???";
                status.Text = "Emergência";
                status.ForeColor = Color.Red;

            }
            else
            {
                MessageBox.Show("Porta fechada! Apertar MCLR", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liga.Text = "Iniciar";
            desliga.Text = "Desligar";
            button2.Text = "Emergência";
            button6.Text = "Iniciar";
            button7.Text = "Desligar";
            label1.Text = "Alfa inicial:";
            label2.Text = "Alfa mínimo:";
            label3.Text = "Tempo de acionamento (s):";
            label12.Text = "Tempo de desaceleração (s):";
            groupBox1.Text = "Configurações";
            button1.Text = "Configurar";
        }

        private void inglêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liga.Text = "Start";
            desliga.Text = "Stop";
            button2.Text = "Emergency";
            button6.Text = "Start";
            button7.Text = "Stop";
            label1.Text = "Inital angle:";
            label2.Text = "Minimum angle:";
            label3.Text = "Starting time (s):";
            label12.Text = "Stopping time (s):";
            groupBox1.Text = "Settings";
            button1.Text = "Set";
        }

        private void alemãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liga.Text = "Starten";
            desliga.Text = "Deaktivieren";
            button2.Text = "Notfall";
            button6.Text = "Starten";
            button7.Text = "Deaktivieren";
        }

        

        public void cálculoDeÂnguloInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox5.Visible)
            {
                this.Height = 370;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                numericUpDown5.Value = 0;
            }
            else
            {
                this.Height = 500;
                groupBox5.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Height = 370;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            numericUpDown5.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angulo_calculo = Math.PI;
            double vrms1 = (double)numericUpDown5.Value;
            double vrms2 = 0;
            while (vrms2 < vrms1)
            {
                angulo_calculo -= 0.0001;
                vrms2 = (220.0) * (1 - (angulo_calculo / ( Math.PI)) + (Math.Sin(2.0 * angulo_calculo) / (2.0 * Math.PI)));
            }
            groupBox6.Visible = true;
            angulo_calculo /= (Math.PI / 180.0);
            label15.Text = angulo_calculo.ToString("0.00") + "º";
            label17.Text = vrms2.ToString("0.00") + " V";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!manual)
            {
                numericUpDown1.Value = (decimal)angulo_calculo;
            }
            else
            {
                MessageBox.Show("Modo manual ativado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       
        private void button6_Click(object sender, EventArgs e)
        {

            if (!conectado)
            {
                MessageBox.Show("Dispositivo desconectado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (falta_energia)
            {
                MessageBox.Show("Não há fornencimento de energia.", "Erro - Problema na rede elétrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Timer4.Start();
            angulo = (int)(((65535.0 - ((41000.0 / 18000.0) * trackBar1.Value))));
            TMR1HX = (angulo >> 8);
            TMR1LX = (angulo & 0x00FF);
            enviar("ANGH" + TMR1HX.ToString("000"));
            enviar("ANGL" + TMR1LX.ToString("000"));
            enviar("ligarmn");
            ligado = true;
            status.Text = "OK";
            status.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                MessageBox.Show("Dispositivo desconectado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ligado)
            {
                MessageBox.Show("Dispositivo já desativado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Timer4.Stop();
            enviar("emergex");
            ligado = false;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            alfa_real.Text = "???";
            tensao_real.Text = "???";
            i_motor.Text = "???";
            status.Text = "Desligado";
            status.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!manual)
            {
                numericUpDown2.Value = (decimal)angulo_calculo;
            }
            else
            {
                MessageBox.Show("Modo manual ativado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manualToolStripMenuItem.Checked)
            {
                automáticoToolStripMenuItem.Checked = false;
                Timer4.Start();
                manual = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox7.Enabled = true;
            }
        }

        private void automáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (automáticoToolStripMenuItem.Checked)
            {
                manualToolStripMenuItem.Checked = false;
                Timer4.Stop();
                manual = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox7.Enabled = false;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        

    }

  
}
