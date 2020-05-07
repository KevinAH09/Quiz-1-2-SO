using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1_2
{
    class Proceso
    {
        int tiempoVida;
        public List<int> recursosNecesarios;
        int tiempoInanicion;
        int tiempoNuevoRecurso;
        List<int> recursosAsignados;
        int tiempoMaximooInanicion;

        public Proceso()
        {
            
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


    }
}
