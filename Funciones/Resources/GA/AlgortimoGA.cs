using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources.GA
{
    public static class AlgortimoGA
    {
        public delegate float FuncionFitness(ValoresFunciones solucion);

        public delegate List<ValoresFunciones> FuncionSeleccion(List<ValoresFunciones> poblacion, List<float> valoresFitness, int param = 3);
        public delegate List<ValoresFunciones> FuncionCruzamiento(List<ValoresFunciones> padres);
        public delegate List<ValoresFunciones> FuncionMutacion(List<ValoresFunciones> solucion, double probabilidad);
        public delegate List<ValoresFunciones> FuncionReemplazo(List<ValoresFunciones> poblacion, List<ValoresFunciones> hijos,
            List<float> fitnesPoblacion, List<float> fitnesHijos);

        static Random rand = new Random();

        public static (ValoresFunciones valores, float fitness) AlgoritmoGeneticoEstacionario(
            int tamañoPoblacion , int dimension ,  int iteraciones , int maxEvaluaciones, FuncionFitness fitness , 
            FuncionSeleccion funcionSeleccion ,  FuncionCruzamiento funcionCruzamiento , double probCruzamiento ,
            FuncionMutacion funcionMutacion , double probMutacion , FuncionReemplazo funcionReemplazo)
        {
            List<ValoresFunciones> poblacion;
            List<ValoresFunciones> padres, hijos;
            List<float> fitnessSoluciones;
            List<float> fitnessHijos;
            double probabilidad;
            int evaluacion = 0;


            poblacion = generarPoblacionAleatoria(tamañoPoblacion, dimension);
            fitnessSoluciones = fitnessDePoblacion(poblacion, fitness);
            evaluacion += tamañoPoblacion;

            for (int i = 0; i < iteraciones && evaluacion < maxEvaluaciones ; i++)
            {
                

                // Seleccion   
                padres = funcionSeleccion(poblacion, fitnessSoluciones);

                //  Cruzamiento
                probabilidad = rand.NextDouble();
                if (probabilidad > probCruzamiento)
                    continue;
                hijos = funcionCruzamiento(padres);

                // Mutacion
                hijos = funcionMutacion(hijos, probMutacion);

                // Reemplazo
                fitnessHijos = fitnessDePoblacion(hijos, fitness);
                evaluacion += hijos.Count;
                poblacion = funcionReemplazo(poblacion, hijos, fitnessSoluciones, fitnessHijos);
                
                fitnessSoluciones = fitnessDePoblacion(poblacion, fitness);
                evaluacion += tamañoPoblacion;
            }

            //Ordena las soluciones por su funcion fitness
            var indexOrdenadaPorFitness = from f in fitnessSoluciones
                                          orderby f
                                          select fitnessSoluciones.IndexOf(f);
            int pos = indexOrdenadaPorFitness.ElementAt(0);
            return (poblacion[pos] , fitnessSoluciones[pos]);
        }
        // Generacional
        public static (ValoresFunciones valores, float fitness) AlgoritmoGeneticoGeneracional(
           int tamañoPoblacion, int dimension, int iteraciones , int maxEvaluaciones, FuncionFitness fitness,
           FuncionSeleccion funcionSeleccion, FuncionCruzamiento funcionCruzamiento, double probCruzamiento,
           FuncionMutacion funcionMutacion, double probMutacion)
        {
            List<ValoresFunciones> poblacion;
            List<ValoresFunciones> nuevaPoblacion;
            List<ValoresFunciones> padres, hijos;
            List<float> fitnessSoluciones;
            double probabilidad;
            int evaluacion = 0;


            poblacion = generarPoblacionAleatoria(tamañoPoblacion, dimension);
            fitnessSoluciones = fitnessDePoblacion(poblacion, fitness);
            evaluacion += tamañoPoblacion;

            for (int i = 0; i < iteraciones && evaluacion < maxEvaluaciones; i++)
            {
                
                nuevaPoblacion = new List<ValoresFunciones>();
                while (nuevaPoblacion.Count < tamañoPoblacion)
                {
                    // Seleccion   
                    padres = funcionSeleccion(poblacion, fitnessSoluciones);

                    //  Cruzamiento
                    probabilidad = rand.NextDouble();
                    if (probabilidad > probCruzamiento)
                        continue;
                    hijos = funcionCruzamiento(padres);

                    // Mutacion
                    hijos = funcionMutacion(hijos, probMutacion);

                    nuevaPoblacion.AddRange(hijos);
                }

                poblacion = nuevaPoblacion;
                fitnessSoluciones = fitnessDePoblacion(poblacion, fitness);
                evaluacion += tamañoPoblacion;
            }


            //Ordena las soluciones por su funcion fitness
            var indexOrdenadaPorFitness = from f in fitnessSoluciones
                                          orderby f
                                          select fitnessSoluciones.IndexOf(f);

            int pos = indexOrdenadaPorFitness.ElementAt(0);
            return (poblacion[pos], fitnessSoluciones[pos]);
        }

        public static List<float> fitnessDePoblacion( List<ValoresFunciones> poblacion , FuncionFitness funcionFitness)
        {
            List<float> fitnessPoblacion = new List<float>();
            fitnessPoblacion.Capacity = poblacion.Count;
            float fitness;

            for (int i = 0; i < poblacion.Count; i++)
            {
                fitness = funcionFitness(poblacion[i]);
                fitnessPoblacion.Add( fitness );
            }

            return fitnessPoblacion;
        }
        public static List<ValoresFunciones> generarPoblacionAleatoria(int tamañoPoblacion , int dimension)
        {
            List<ValoresFunciones> poblacion = new List<ValoresFunciones>();

            for (int i = 0; i < tamañoPoblacion; i++)
            {
                ValoresFunciones cromosoma = generarSolucionAleatorio(dimension);
                poblacion.Add( cromosoma );
            }           

            return poblacion;
        }

        private static ValoresFunciones generarSolucionAleatorio(int dimension)
        {
            ValoresFunciones solucion =  new ValoresFunciones();
            solucion.listaDeValoresDeX = new List<float>();
            solucion.NumDimensiones = dimension;

            for (int i = 0; i < solucion.NumDimensiones; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) - 10;
                solucion.listaDeValoresDeX.Add(ValorX);
            }
            return solucion;
        }

    }
}
