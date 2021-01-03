using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources
{
    
    public static class Funcion
    {        
        public static float Alpine( ValoresFunciones valoresFunciones)
        {
            float suma = 0;

            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (float) Math.Abs((valoresFunciones.listaDeValoresDeX[i] * 
                        Math.Sin(valoresFunciones.listaDeValoresDeX[i])) + 
                        (0.1 * valoresFunciones.listaDeValoresDeX[i]));          
            }

            return suma;
        }

        public static float Dixon_Price(ValoresFunciones valoresFunciones)
        {
            float suma = 0;
            suma = (float)Math.Pow((valoresFunciones.listaDeValoresDeX[0] - 1), 2);
            for (int i = 1; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (float)( (i + 1) * Math.Pow(((2 * Math.Sin(valoresFunciones.listaDeValoresDeX[i])) - valoresFunciones.listaDeValoresDeX[i - 1]), 2));
            }

            return suma;
        }

        public static float Quintic(ValoresFunciones valoresFunciones)
        {
            float suma = 0;
            float x_1 = valoresFunciones.listaDeValoresDeX[0];

            List<float> x = valoresFunciones.listaDeValoresDeX;

            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (float) Math.Abs((Math.Pow(x[i],5)) - (3 * (Math.Pow(x[i], 4))) + (4 * (Math.Pow(x[i], 3))) - (2 * (Math.Pow(x[i], 2))) - (10 * x_1) - 4);
            }

            return suma;
        }

        public static float Schwefel(ValoresFunciones valoresFunciones)
        {
            float suma = 0;
            
            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (float) Math.Pow(valoresFunciones.listaDeValoresDeX[i],10);               
            }

            return suma;
        }

        public static float Streched_V(ValoresFunciones valoresFunciones)
        {
            float suma = 0;
            
            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count-1; i++)
            {
                suma += (float) (Math.Pow((Math.Pow(valoresFunciones.listaDeValoresDeX[i + 1], 2) + Math.Pow(valoresFunciones.listaDeValoresDeX[i], 2)), 0.25) 
                        * (Math.Pow((Math.Sin(50 *(Math.Pow((Math.Pow(valoresFunciones.listaDeValoresDeX[i + 1], 2) + Math.Pow(valoresFunciones.listaDeValoresDeX[i], 2)), 0.1)) )), 2) + 0.1));
               
            }

            return suma;
        }

        public static float Suma_Cuadrados(ValoresFunciones valoresFunciones)
        {
            float suma = 0;
            
            for (int i = 0; i < valoresFunciones.listaDeValoresDeX.Count; i++)
            {
                suma += (float) ((i + 1) * Math.Pow(valoresFunciones.listaDeValoresDeX[i], 2));
            }

            return suma;
        }
    }
}
