using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources.GA
{
    public static class MetodosMutacion
    {
        static Random rand = new Random();

        public static List<ValoresFunciones> MutacionEnReales(List<ValoresFunciones> elementos, double probabilidad)
        {
            List<ValoresFunciones> elementosMutados = elementos.ConvertAll(x => (ValoresFunciones)x.Clone());
            double probActual;
            int dimension;

            // Realiza la operacion en cada solucion
            foreach (var item in elementosMutados)
            {
                // Obtiene la dimension de la solucion
                dimension = item.listaDeValoresDeX.Count;

                // Realiza la operacion en cada delemento de la solucion
                for (int i = 0; i < dimension; i++)
                {
                    // Obtiene una probabilidad
                    probActual = rand.NextDouble();

                    //Verifica que este en el rango de probabilidad
                    if (probActual <= probabilidad)
                    {
                        // Muta el valor
                        item.listaDeValoresDeX[i] = (float)(Math.Round(item.listaDeValoresDeX[i] * Math.Sin((item.listaDeValoresDeX[i] * Math.PI) / 25), 6));
                        //item.listaDeValoresDeX[i] = item.listaDeValoresDeX[i] * (float)Math.Sin(item.listaDeValoresDeX[i]);
                    }

                }
            }
            return elementosMutados;
        }

    }
}
