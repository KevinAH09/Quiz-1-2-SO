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

        public HiloProceso(Proceso proceso)
        {
            this.proceso = proceso;
            this.Tick += new EventHandler(TimerEventProcessor);
            this.Interval = 1000;
            this.Start();
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            

        }
    }
}
