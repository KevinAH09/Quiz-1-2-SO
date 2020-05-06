using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1_2
{
    public class Proceso
    {
        int tiempoVida;
        List<int> recursosNecesarios;
        int tiempoInanicion;
        int tiempoNuevoRecurso;
        List<int> recursosAsignados;
        int tiempoMaximooInanicion;


        public Proceso(int tiempoVida, List<int> recursosNecesarios, int tiempoInanicion, int tiempoNuevoRecurso, List<int> recursosAsignados, int tiempoMaximooInanicion) : this(tiempoVida, recursosNecesarios, tiempoInanicion, tiempoNuevoRecurso, recursosAsignados)
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
