using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    
    public class Proceso 
    {
        Random r = new Random();
        private int idProceso;
        private int tiempoVida;
        public List<int> recursosNecesarios;
        private int tiempoInanicion;
        private int tiempoNuevoRecurso;
        public List<int> recursosAsignados;
        private int tiempoMaximooInanicion;
        
        public Proceso(int idproceso, int disHDD, int disRAM, int disCDROM, int disAudio, int disEscaner, int disImpresora)
        {
            this.idProceso=idproceso;
            this.tiempoMaximooInanicion = r.Next(10,30);
            this.tiempoVida = r.Next(5,20);
            this.recursosNecesarios = new List<int>() { r.Next(Form1.hddMAx) , r.Next(Form1.ramMAx), r.Next(Form1.cdMAx), r.Next(Form1.audioMAx), r.Next(Form1.scanerMAx), r.Next(Form1.impresoraMAx) };
            this.tiempoInanicion = 0;
            this.tiempoNuevoRecurso = r.Next(5,this.tiempoVida);
            this.recursosAsignados = new List<int>() { 0,0,0,0,0,0 };

            if(this.recursosNecesarios[0]> disHDD){

                this.recursosAsignados[0] = r.Next(disHDD);
            }
            else
            {
                this.recursosAsignados[0] = r.Next(this.recursosNecesarios[0]);
            }


            if (this.recursosNecesarios[1] > disRAM)
            {
                this.recursosAsignados[1] = r.Next(disRAM);
            }
            else
            {
                this.recursosAsignados[1] = r.Next(this.recursosNecesarios[1]);
            }


            if (this.recursosNecesarios[2] > disCDROM)
            {
                this.recursosAsignados[2] = r.Next(disCDROM);
            }
            else
            {
                this.recursosAsignados[2] = r.Next(this.recursosNecesarios[2]);
            }


            if (this.recursosNecesarios[3] > disAudio)
            {
                this.recursosAsignados[3] = r.Next(disAudio);
            }
            else
            {
                this.recursosAsignados[3] = r.Next(this.recursosNecesarios[3]);
            }


            if (this.recursosNecesarios[4] > disEscaner)
            {
                this.recursosAsignados[4] = r.Next(disEscaner);
            }
            else
            {
                this.recursosAsignados[4] = r.Next(this.recursosNecesarios[4]);
            }


            if (this.recursosNecesarios[5] > disImpresora)
            {
                this.recursosAsignados[5] = r.Next(disImpresora);
            }
            else
            {
                this.recursosAsignados[5] = r.Next(this.recursosNecesarios[5]);
            }

        }

        public Proceso(int tiempoVida, List<int> recursosNecesarios, int tiempoInanicion, int tiempoNuevoRecurso, List<int> recursosAsignados, int tiempoMaximooInanicion)
        {
            this.tiempoMaximooInanicion = tiempoMaximooInanicion;
            this.tiempoVida = tiempoVida;
            this.recursosNecesarios = recursosNecesarios;
            this.tiempoInanicion = tiempoInanicion;
            this.tiempoNuevoRecurso = tiempoNuevoRecurso;
            this.recursosAsignados = recursosAsignados;
        }
        public int ID_Proceso
        {
            get { return idProceso; }
        }
        public int Tiempo_de_Vida
        {
            set { tiempoVida = value; }
            get { return tiempoVida; }

        }
        public int Tiempo_Inanicion
        {
            set { tiempoInanicion = value; }
            get { return tiempoInanicion; }

        }
        public string Recursos_Necesarios
        {
            get { return "H:"+ string.Concat(recursosNecesarios[0]) + "   R:" + string.Concat(recursosNecesarios[1]) + "   C:" + string.Concat(recursosNecesarios[2]) + "   A:" + string.Concat(recursosNecesarios[3]) + "   S:" + string.Concat(recursosNecesarios[4]) + "   I:" + string.Concat(recursosNecesarios[5]); }

        }
        public int Tiempo_Nuevo_Recurso
        {
            set { tiempoNuevoRecurso = value; }
            get { return tiempoNuevoRecurso; }

        }
        public string Recursos_Asignados
        {
            get { return "H:" +string.Concat(recursosAsignados[0]) + "   R:" + string.Concat(recursosAsignados[1]) + "   C:" + string.Concat(recursosAsignados[2]) + "   A:" + string.Concat(recursosAsignados[3]) + "   S:" + string.Concat(recursosAsignados[4]) + "   I:" + string.Concat(recursosAsignados[5]); }

        }
        public int Tiempo_Maximoo_de_Inanicion
        {
            set { tiempoMaximooInanicion = value; }
            get { return tiempoMaximooInanicion; }
        } 
    }
}
