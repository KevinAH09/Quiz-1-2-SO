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
        DataGridView lisgrip;
        Proceso proceso;
        TextBox hdd;
        TextBox rom;
        TextBox audio;
        TextBox scaner;
        TextBox impresora;
        TextBox cd;

        public HiloProceso(Proceso proceso, DataGridView data,TextBox h, TextBox r, TextBox c, TextBox a, TextBox s, TextBox i)
        {
            lisgrip = data;
            this.hdd = h;
            this.rom = r;
            this.cd = c;
            this.audio = a;
            this.scaner = s;
            this.impresora = i;
            this.proceso = proceso;
            this.Tick += new EventHandler(TimerEventProcessor);
            this.Interval = 1000;
            this.Start();
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(VerificacionDeNuevoRecursos);
            myTimer.Interval = proceso.Tiempo_Nuevo_Recurso;
            myTimer.Start();
            
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
             if (Form1.cerrojo)
            {
                Form1.cerrojo = false;
                if (this.proceso.Tiempo_Inanicion < this.proceso.Tiempo_Maximoo_de_Inanicion)
                {
                    this.proceso.Tiempo_Inanicion++;
                }
                else if (this.proceso.Tiempo_Inanicion >= this.proceso.Tiempo_Maximoo_de_Inanicion)
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
                        dif = this.proceso.recursosNecesarios[5] - this.proceso.recursosAsignados[4];
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
                    this.lisgrip.DataSource = Form1.procesos;
                }
                Form1.cerrojo = true;
            } 
        }
        private void VerificacionDeNuevoRecursos(Object myObject, EventArgs myEventArgs)
        {

        }
    }
}
