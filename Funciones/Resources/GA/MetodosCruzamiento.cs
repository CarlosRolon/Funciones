using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources.GA
{
    public static class MetodosCruzamiento
    {
        static Random rand = new Random();

       
        public static List<ValoresFunciones> CruzamientoArimetico(List<ValoresFunciones> padresO)
        {
            List<ValoresFunciones> padres = padresO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> hijos = padresO.ConvertAll(x => (ValoresFunciones)x.Clone());
            int tamañoSolucion = padres[0].NumDimensiones;
            float w = (float)rand.NextDouble();

            for (int i = 0; i < tamañoSolucion; i++)
            {
                hijos[0].listaDeValoresDeX[i] = w * padres[0].listaDeValoresDeX[i] + (1 - w) * padres[1].listaDeValoresDeX[i];
                hijos[1].listaDeValoresDeX[i] = w * padres[1].listaDeValoresDeX[i] + (1 - w) * padres[0].listaDeValoresDeX[i];
            }

            return hijos;
        }

        public static List<ValoresFunciones> CruzamientoPlano(List<ValoresFunciones> padresO)
        {
            List<ValoresFunciones> padres = padresO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> hijos = padresO.ConvertAll(x => (ValoresFunciones)x.Clone());
            int tamañoSolucion = padres[0].NumDimensiones;
            float valorMinimo, valorMaximo;
            float w = (float)rand.NextDouble();

            for (int i = 0; i < tamañoSolucion; i++)
            {
                if (padres[0].listaDeValoresDeX[i] < padres[1].listaDeValoresDeX[i])
                {
                    valorMinimo = padres[0].listaDeValoresDeX[i];
                    valorMaximo = padres[1].listaDeValoresDeX[i];
                }
                else
                {
                    valorMinimo = padres[1].listaDeValoresDeX[i];
                    valorMaximo = padres[0].listaDeValoresDeX[i];
                }

                hijos[0].listaDeValoresDeX[i] = valorMinimo + ( (float)rand.NextDouble() * (valorMaximo - valorMinimo));
                hijos[1].listaDeValoresDeX[i] = valorMinimo + ( (float)rand.NextDouble() * (valorMaximo - valorMinimo));
            }

            return hijos;
        }



    }
}
