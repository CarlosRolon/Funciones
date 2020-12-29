using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources.GA
{
    public static class MetodosSeleccion
    {
        static Random rand = new Random();
        public static List<ValoresFunciones> NPM(List<ValoresFunciones> poblacionS, List<float> valoresFitness , int N = 3)
        {
            List<ValoresFunciones> poblacion = new List<ValoresFunciones>(poblacionS);
            List<ValoresFunciones> padres = new List<ValoresFunciones>();
            ValoresFunciones padre1, padre2 ;
            List<int> posiciones = new List<int>();
            int posPadre1, posPadre2 , valAleatorio , posTempPadre2;
            double distanciaMin , distancia;
            posPadre2 = 0;


            // Genera una lista de las posiciones de la poblacion
            for (int i = 0; i < poblacion.Count; i++)
                posiciones.Add(i);

            //Proceso para seleccionar el primer padre aleatoriamente
            //  Selecciona una valor aleatoriamente
            valAleatorio = rand.Next(0, posiciones.Count);
            //   Se selecciona aleatoriamente la posicion
            posPadre1 = posiciones[valAleatorio];
            //   Se accede y almacena el Padre 1
            padre1 = (ValoresFunciones)poblacion[posPadre1].Clone();
            padres.Add(padre1);
            //   Elimina la posicion del padre 1 de las posibles
            posiciones.RemoveAt(posPadre1);

            // Busca el elemento mas cercano de N candidatos aleatorios
            distanciaMin = float.PositiveInfinity;
            for (int i = 0; i < N; i++)
            {
                valAleatorio = rand.Next(0, posiciones.Count);
                posTempPadre2 = posiciones[valAleatorio];
                distancia = distanciaSoluciones(padre1, poblacion[posTempPadre2]);
               

                if (distancia < distanciaMin)
                {
                    posPadre2 = posTempPadre2;
                    distanciaMin = distancia;
                }

                posiciones.RemoveAt(valAleatorio);
            }
            padre2 = (ValoresFunciones)poblacion[posPadre2].Clone();
            padres.Add(padre2);              
            return padres;
        }

        public static List<ValoresFunciones> Proporcional(List<ValoresFunciones> poblacionS , List<float> valoresFitness , int extra = 0 )
        {
            List<ValoresFunciones> poblacion = new List<ValoresFunciones>(poblacionS);
            List<ValoresFunciones> padres = new List<ValoresFunciones>();
            List<double> regiones = new List<double>();
            bool encontroRegion = false;

            // Sumatoria de la funcion fitness de los elementos de la pobliacion
            float sumaFitness = valoresFitness.Sum();

            // SELECCION PRIMER PADRE 
            // Se obtiene la region
            double puntero = rand.NextDouble();

            // Se busca la region 
            double region = 0;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                //Establece la region
                region += 1 - (valoresFitness[i] / sumaFitness);
                // Valida si esta dentro de la region
                if (region > puntero)
                {
                    // Guarda padre
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                    poblacion.RemoveAt(i);
                }
            }

            // SELECCION SEGUNDO PADRE 
            // Se obtiene la region
            sumaFitness = valoresFitness.Sum();
            puntero = rand.NextDouble();

            // Se busca la region de la fecha
            region = 0;
            encontroRegion = false;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                region += 1 - (valoresFitness[i] / sumaFitness);
                if (region > puntero)
                {
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                }
            }
            return padres;
        }

        public static List<ValoresFunciones> Torneo(List<ValoresFunciones> poblacionS, List<float> valoresFitnessS, int K = 3)
        {
            List<ValoresFunciones> poblacion = new List<ValoresFunciones>(poblacionS);
            List<ValoresFunciones> padres = new List<ValoresFunciones>();
            List<float> valoresFitness = new List<float>(valoresFitnessS);
            List<float> fitnessTorneo = new List<float>();
            List<int> posTorneo = new List<int>();
            List<int> posDisponibles = new List<int>();
            int posAleatoria, pos;

            // PADRE 1
            // Genera una lista de las posiciones de la poblacion
            for (int i = 0; i < poblacion.Count; i++)
                posDisponibles.Add(i);

            // Se selecciona K para el torneo
            for (int i = 0; i < K; i++)
            {
                posAleatoria = rand.Next(0, posDisponibles.Count);
                pos = posDisponibles[posAleatoria];
                posTorneo.Add(pos);
                fitnessTorneo.Add(valoresFitness[pos]);
                posDisponibles.RemoveAt(posAleatoria);
            }

            var indexOrdenadaPorFitness = from f in fitnessTorneo
                                          orderby f
                                          select fitnessTorneo.IndexOf(f);

            pos = indexOrdenadaPorFitness.ElementAt(0);
            pos = posTorneo[pos];
            padres.Add(poblacion[pos]);
            poblacion.RemoveAt(pos);
            valoresFitness.RemoveAt(pos);


            // PADRE 2
            // Genera una lista de las posiciones de la poblacion
            posDisponibles.Clear();
            posTorneo.Clear();
            fitnessTorneo.Clear();
            for (int i = 0; i < poblacion.Count; i++)
                posDisponibles.Add(i);

            // Se selecciona K para el torneo
            for (int i = 0; i < K; i++)
            {
                posAleatoria = rand.Next(0, posDisponibles.Count);
                pos = posDisponibles[posAleatoria];
                posTorneo.Add(pos);
                fitnessTorneo.Add(valoresFitness[pos]);
                posDisponibles.RemoveAt(posAleatoria);
            }

            indexOrdenadaPorFitness = from f in fitnessTorneo
                                      orderby f
                                      select fitnessTorneo.IndexOf(f);

            pos = indexOrdenadaPorFitness.ElementAt(0);
            pos = posTorneo[pos];
            padres.Add(poblacion[pos]);
        
            return padres;
        }

        public static double distanciaSoluciones(ValoresFunciones f1, ValoresFunciones f2)
        {
            double distancia = 0;

            for (int i = 0; i < f1.listaDeValoresDeX.Count; i++)
            {
                distancia += Math.Sqrt(Math.Pow(f1.listaDeValoresDeX[i], 2) + Math.Pow(f2.listaDeValoresDeX[i], 2));
            }
            return distancia;
        }

    }
}
