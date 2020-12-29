using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources
{
    public static class Funcion
    {
        public static float Ejemplo( ValoresFunciones valoresFunciones)
        {
            float suma = 0;

            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (valoresFunciones.listaDeValoresDeX[i]) * (valoresFunciones.listaDeValoresDeX[i]);
            }

            return suma;
        }

        public static float Ejemplo2(ValoresFunciones valoresFunciones)
        {
            float suma = 0;

            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (valoresFunciones.listaDeValoresDeX[i]) * .5125f;
            }

            return suma;
        }
    }
}
