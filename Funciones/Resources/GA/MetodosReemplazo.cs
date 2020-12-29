using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources.GA
{
    static public class MetodosReemplazo
    {
        static Random rand = new Random();

        public static List<ValoresFunciones> Aleatorio(List<ValoresFunciones> poblacionO, List<ValoresFunciones> hijosO ,
            List<float> fitnesPoblacionO, List<float> fitnesHijosO)
        {
            List<ValoresFunciones> poblacion = poblacionO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> hijos = hijosO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> poblacionAleatorio = new List<ValoresFunciones>();
            int pos;

            poblacion = poblacion.Union(hijos).ToList();

            for (int i = 0; i < poblacionO.Count; i++)
            {
                pos = rand.Next(poblacion.Count);
                poblacionAleatorio.Add(poblacion[pos]);
                poblacion.RemoveAt(pos);
            }
            return poblacionAleatorio;
        }

        public static List<ValoresFunciones> Fitness(List<ValoresFunciones> poblacionO, List<ValoresFunciones> hijosO,
            List<float> fitnesPoblacionO, List<float> fitnesHijosO)
        {
            
            List<ValoresFunciones> poblacion = poblacionO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> hijos = hijosO.ConvertAll(x => (ValoresFunciones)x.Clone());
            List<ValoresFunciones> nuevaPoblacion = new List<ValoresFunciones>();
            List<float> fitnesPoblacion = fitnesPoblacionO.ToList();
            List<float> fitnesHijos = new List<float>(fitnesHijosO);
            int index;

            

            fitnesPoblacion = fitnesPoblacion.Concat(fitnesHijos).ToList();
            poblacion = poblacion.Union(hijos).ToList();

            var indexOrdenadaPorFitness = (from f in fitnesPoblacion
                                          orderby f
                                           select fitnesPoblacion.IndexOf(f)).ToList();


            for (int i = 0; i < poblacionO.Count; i++)
            {
                index = indexOrdenadaPorFitness.ElementAt(i);
                nuevaPoblacion.Add(poblacion[index]);
            }                  
            return nuevaPoblacion;
        }

      
        
    }
}
