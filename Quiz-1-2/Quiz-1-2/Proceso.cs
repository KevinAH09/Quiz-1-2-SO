using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    
    class Proceso 
    {
        Random r = new Random();
        private int idProceso;
        private int tiempoVida;
        public List<int> recursosNecesarios;
        private int tiempoInanicion;
        private int tiempoNuevoRecurso;
        public List<int> recursosAsignados;
        private int tiempoMaximooInanicion;
        
        public Proceso(int idproceso,int maxHDD,int maxRAM,int CDROM, int maxAudio,int maxEscaner,int maxImpresora)
        {
            this.idProceso=idproceso;
            this.tiempoMaximooInanicion = r.Next(10,100);
            this.tiempoVida = r.Next(11,100);
            this.recursosNecesarios = new List<int>() { r.Next(maxHDD) , r.Next(maxRAM), r.Next(CDROM), r.Next(maxAudio), r.Next(maxEscaner), r.Next(maxImpresora) };
            this.tiempoInanicion = r.Next(11,200);
            this.tiempoNuevoRecurso = r.Next(11,200);
            this.recursosAsignados = new List<int>() { r.Next(maxHDD), r.Next(maxRAM), r.Next(CDROM), r.Next(maxAudio), r.Next(maxEscaner), r.Next(maxImpresora) };

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
