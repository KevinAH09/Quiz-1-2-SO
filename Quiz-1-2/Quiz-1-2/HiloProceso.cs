using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    class HiloProceso : Timer
    {
        Random r = new Random();
        DataGridView lisgrip;
        Proceso proceso;
        TextBox hdd;
        TextBox rom;
        TextBox audio;
        TextBox scaner;
        TextBox impresora;
        TextBox cd;
        bool estadoProceso;

        public HiloProceso(Proceso proceso, DataGridView data,TextBox h, TextBox r, TextBox c, TextBox a, TextBox s, TextBox i)
        {
            lisgrip = data;
            this.hdd = h;
            this.rom = r;
            this.cd = c;
            this.audio = a;
            this.scaner = s;
            this.impresora = i;
            this.estadoProceso = false;
            this.proceso = proceso;
            this.Tick += new EventHandler(TimerEventProcessor);
            this.Interval = 1000;
            this.Start();
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(VerificacionDeNuevoRecursos);
            myTimer.Interval = proceso.Tiempo_Nuevo_Recurso*1000;
            myTimer.Start();
            
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (Form1.cerrojo)
            {
                Form1.cerrojo = false;
                if (!estadoProceso)
                {
                    if (this.proceso.Tiempo_Inanicion < this.proceso.Tiempo_Maximoo_de_Inanicion)
                    {
                        this.proceso.Tiempo_Inanicion++;
                    }
                    if (this.proceso.Tiempo_Inanicion >= this.proceso.Tiempo_Maximoo_de_Inanicion)
                    {
                        this.hdd.Text = string.Concat(int.Parse(this.hdd.Text) + this.proceso.recursosAsignados[0]);
                        this.rom.Text = string.Concat(int.Parse(this.rom.Text) + this.proceso.recursosAsignados[1]);
                        this.cd.Text = string.Concat(int.Parse(this.cd.Text) + this.proceso.recursosAsignados[2]);
                        this.audio.Text = string.Concat(int.Parse(this.audio.Text) + this.proceso.recursosAsignados[3]);
                        this.scaner.Text = string.Concat(int.Parse(this.scaner.Text) + this.proceso.recursosAsignados[4]);
                        this.impresora.Text = string.Concat(int.Parse(this.impresora.Text) + this.proceso.recursosAsignados[5]);
                        Form1.procesos.Remove(this.proceso);

                        this.Stop();
                    }
                    else
                    {

                        int dis;
                        int dif;
                        if (int.Parse(this.hdd.Text) >= 0)
                        {
                            dis = int.Parse(this.hdd.Text);
                            dif = this.proceso.recursosNecesarios[0] - this.proceso.recursosAsignados[0];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[0] += dif;
                                    dis -= dif;
                                    this.hdd.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[0] += dis;
                                    dis = 0;
                                    this.hdd.Text = (string.Concat(dis));
                                }
                            }
                        }
                        if (int.Parse(this.rom.Text) >= 0)
                        {
                            dis = int.Parse(this.rom.Text);
                            dif = this.proceso.recursosNecesarios[1] - this.proceso.recursosAsignados[1];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[1] += dif;
                                    dis -= dif;
                                    this.rom.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[1] += dis;
                                    dis = 0;
                                    this.rom.Text = (string.Concat(dis));
                                }
                            }
                        }
                        if (int.Parse(this.cd.Text) >= 0)
                        {
                            dis = int.Parse(this.cd.Text);
                            dif = this.proceso.recursosNecesarios[2] - this.proceso.recursosAsignados[2];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[2] += dif;
                                    dis -= dif;
                                    this.cd.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[2] += dis;
                                    dis = 0;
                                    this.cd.Text = (string.Concat(dis));
                                }
                            }
                        }
                        if (int.Parse(this.audio.Text) >= 0)
                        {
                            dis = int.Parse(this.audio.Text);
                            dif = this.proceso.recursosNecesarios[3] - this.proceso.recursosAsignados[3];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[3] += dif;
                                    dis -= dif;
                                    this.audio.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[3] += dis;
                                    dis = 0;
                                    this.audio.Text = (string.Concat(dis));
                                }
                            }
                        }
                        if (int.Parse(this.scaner.Text) >= 0)
                        {
                            dis = int.Parse(this.scaner.Text);
                            dif = this.proceso.recursosNecesarios[4] - this.proceso.recursosAsignados[4];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[4] += dif;
                                    dis -= dif;
                                    this.scaner.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[4] += dis;
                                    dis = 0;
                                    this.scaner.Text = (string.Concat(dis));
                                }
                            }
                        }
                        if (int.Parse(this.impresora.Text) >= 0)
                        {
                            dis = int.Parse(this.impresora.Text);
                            dif = this.proceso.recursosNecesarios[5] - this.proceso.recursosAsignados[5];
                            if (dif > 0)
                            {
                                if (dif <= dis)
                                {
                                    this.proceso.recursosAsignados[5] += dif;
                                    dis -= dif;
                                    this.impresora.Text = (string.Concat(dis));
                                }
                                else
                                {
                                    this.proceso.recursosAsignados[5] += dis;
                                    dis = 0;
                                    this.impresora.Text = (string.Concat(dis));
                                }
                            }
                        }

                    }

                    this.lisgrip.DataSource = null;
                    this.lisgrip.DataSource = Form1.procesos;
                    lisgrip.Columns[0].Width = 100;
                    lisgrip.Columns[1].Width = 110;
                    lisgrip.Columns[2].Width = 110;
                    lisgrip.Columns[3].Width = 210;
                    lisgrip.Columns[4].Width = 150;
                    lisgrip.Columns[5].Width = 210;
                    lisgrip.Columns[6].Width = 160;
                }
                
                if(this.proceso.recursosAsignados.SequenceEqual(this.proceso.recursosNecesarios))
                {
                    this.hdd.Text = string.Concat(int.Parse(this.hdd.Text) + this.proceso.recursosAsignados[0]);
                    this.rom.Text = string.Concat(int.Parse(this.rom.Text) + this.proceso.recursosAsignados[1]);
                    this.cd.Text = string.Concat(int.Parse(this.cd.Text) + this.proceso.recursosAsignados[2]);
                    this.audio.Text = string.Concat(int.Parse(this.audio.Text) + this.proceso.recursosAsignados[3]);
                    this.scaner.Text = string.Concat(int.Parse(this.scaner.Text) + this.proceso.recursosAsignados[4]);
                    this.impresora.Text = string.Concat(int.Parse(this.impresora.Text) + this.proceso.recursosAsignados[5]);
                    this.proceso.recursosAsignados = new List<int>() { 0, 0, 0, 0, 0, 0 };
                    this.proceso.recursosNecesarios = new List<int>() { 0, 0, 0, 0, 0, 0 };
                    this.proceso.Tiempo_Inanicion = 0;
                    estadoProceso = true;
                }
                Form1.cerrojo = true;
            } 
        }
        private void VerificacionDeNuevoRecursos(Object myObject, EventArgs myEventArgs)
        {

            if (Form1.cerrojo)
            {
                Form1.cerrojo = false;
                this.hdd.Text = string.Concat(int.Parse(this.hdd.Text) + this.proceso.recursosAsignados[0]);
                this.rom.Text = string.Concat(int.Parse(this.rom.Text) + this.proceso.recursosAsignados[1]);
                this.cd.Text = string.Concat(int.Parse(this.cd.Text) + this.proceso.recursosAsignados[2]);
                this.audio.Text = string.Concat(int.Parse(this.audio.Text) + this.proceso.recursosAsignados[3]);
                this.scaner.Text = string.Concat(int.Parse(this.scaner.Text) + this.proceso.recursosAsignados[4]);
                this.impresora.Text = string.Concat(int.Parse(this.impresora.Text) + this.proceso.recursosAsignados[5]);

                this.proceso.Tiempo_Maximoo_de_Inanicion = r.Next(10, 30);
                this.proceso.Tiempo_de_Vida += r.Next(5, 20);
                this.proceso.recursosNecesarios = new List<int>() { r.Next(Form1.hddMAx), r.Next(Form1.ramMAx), r.Next(Form1.cdMAx), r.Next(Form1.audioMAx), r.Next(Form1.scanerMAx), r.Next(Form1.impresoraMAx) };
                this.proceso.recursosAsignados = new List<int>() { 0, 0, 0, 0, 0, 0 };
                if (this.proceso.recursosNecesarios[0] > int.Parse(this.hdd.Text))
                {
                    this.proceso.recursosAsignados[0] = r.Next(int.Parse(this.hdd.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[0] = r.Next(this.proceso.recursosNecesarios[0]);
                }


                if (this.proceso.recursosNecesarios[1] > int.Parse(this.rom.Text))
                {
                    this.proceso.recursosAsignados[1] = r.Next(int.Parse(this.rom.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[1] = r.Next(this.proceso.recursosNecesarios[1]);
                }


                if (this.proceso.recursosNecesarios[2] > int.Parse(this.cd.Text))
                {
                    this.proceso.recursosAsignados[2] = r.Next(int.Parse(this.cd.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[2] = r.Next(this.proceso.recursosNecesarios[2]);
                }


                if (this.proceso.recursosNecesarios[3] > int.Parse(this.audio.Text))
                {
                    this.proceso.recursosAsignados[3] = r.Next(int.Parse(this.audio.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[3] = r.Next(this.proceso.recursosNecesarios[3]);
                }


                if (this.proceso.recursosNecesarios[4] > int.Parse(this.scaner.Text))
                {
                    this.proceso.recursosAsignados[4] = r.Next(int.Parse(this.scaner.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[4] = r.Next(this.proceso.recursosNecesarios[4]);
                }


                if (this.proceso.recursosNecesarios[5] > int.Parse(this.impresora.Text))
                {
                    this.proceso.recursosAsignados[5] = r.Next(int.Parse(this.impresora.Text));
                }
                else
                {
                    this.proceso.recursosAsignados[5] = r.Next(this.proceso.recursosNecesarios[5]);
                }

                this.hdd.Text = string.Concat(int.Parse(hdd.Text) - this.proceso.recursosAsignados[0]);
                this.rom.Text = string.Concat(int.Parse(rom.Text) - this.proceso.recursosAsignados[1]);
                this.cd.Text = string.Concat(int.Parse(cd.Text) - this.proceso.recursosAsignados[2]);
                this.audio.Text = string.Concat(int.Parse(audio.Text) - this.proceso.recursosAsignados[3]);
                this.scaner.Text = string.Concat(int.Parse(scaner.Text) - this.proceso.recursosAsignados[4]);
                this.impresora.Text = string.Concat(int.Parse(impresora.Text) - this.proceso.recursosAsignados[5]);
                Form1.cerrojo = true;
            }
        }
    }
}
