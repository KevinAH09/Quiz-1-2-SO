﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    class HiloProceso : Timer
    {
        Proceso proceso;
        TextBox hdd;
        TextBox rom;
        TextBox audio;
        TextBox scaner;
        TextBox impresora;
        TextBox cd;

        public HiloProceso(Proceso proceso,TextBox h, TextBox r, TextBox c, TextBox a, TextBox s, TextBox i)
        {
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
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            if (this.proceso.Tiempo_Inanicion < this.proceso.Tiempo_Maximoo_de_Inanicion)
            {
                this.proceso.Tiempo_Inanicion++;
            }
            else
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
        }
    }
}
