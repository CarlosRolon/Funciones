using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funciones.Resources;
using Funciones.Resources.GA;

namespace Funciones
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmbFuncion.SelectedIndex = 0;
            cmbVersion.SelectedIndex = 0;
            cmbMetSeleccion.SelectedIndex = 0;
            cmbMetCruzamiento.SelectedIndex = 0;
            cmbMetReemplazo.SelectedIndex = 0;
        }

 

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AlgortimoGA.FuncionFitness funcionFitness = Funcion.Ejemplo ;
            AlgortimoGA.FuncionSeleccion funcionSeleccion = MetodosSeleccion.Proporcional;
            AlgortimoGA.FuncionCruzamiento funcionCruzamiento = MetodosCruzamiento.CruzamientoArimetico;
            AlgortimoGA.FuncionMutacion funcionMutacion = MetodosMutacion.MutacionEnReales;
            AlgortimoGA.FuncionReemplazo funcionReemplazo = MetodosReemplazo.Aleatorio;

            List<ValoresFunciones> valoresSoluciones = new List<ValoresFunciones>();
            List<float> valoresFitness = new List<float>();
            List<float> valoresTiempo = new List<float>();
            Stopwatch timeMeasure = new Stopwatch();
            ValoresFunciones r = new ValoresFunciones();
            float f,t;


            switch ( cmbFuncion.SelectedIndex )
            {
                case 0:
                    funcionFitness = Funcion.Ejemplo;
                    break;
                case 1:
                    funcionFitness = Funcion.Ejemplo2;
                    break;
                case 2:
                    funcionFitness = Funcion.Ejemplo;
                    break;
                case 3:
                    funcionFitness = Funcion.Ejemplo;
                    break;
                case 4:
                    funcionFitness = Funcion.Ejemplo;
                    break;
            }

            switch ( cmbMetSeleccion.SelectedIndex )
            {
                case 0:
                    funcionSeleccion = MetodosSeleccion.Proporcional;
                    break;
                case 1:
                    funcionSeleccion = MetodosSeleccion.NPM;
                    break;
                case 2:
                    funcionSeleccion = MetodosSeleccion.Torneo;
                    break;
            }

            switch (cmbMetCruzamiento.SelectedIndex)
            {
                case 0:
                    funcionCruzamiento = MetodosCruzamiento.CruzamientoArimetico;
                    break;
                case 1:
                    funcionCruzamiento = MetodosCruzamiento.CruzamientoPlano;
                    break;
            }

            switch (cmbMetReemplazo.SelectedIndex)
            {
                case 0:
                    funcionReemplazo = MetodosReemplazo.Fitness;
                    break;
                case 1:
                    funcionReemplazo = MetodosReemplazo.Aleatorio;
                    break;
            }

            /// GENERA LAS SOLUCIONES
            int cantSoluciones = 20;

           
            switch (cmbVersion.SelectedIndex)
            {
                // ESTACIONARIO
                case 0:

                    for (int i = 0; i < cantSoluciones; i++)
                    {
                        
                        timeMeasure.Start();
                        

                        (r , f) = AlgortimoGA.AlgoritmoGeneticoEstacionario(
                            10, (int)nupDimension.Value, (int)nupIteraciones.Value,
                            funcionFitness, funcionSeleccion, funcionCruzamiento, (double)nupProbCruzamiento.Value,
                            funcionMutacion, (double)nupProbMutacion.Value, funcionReemplazo);

                        timeMeasure.Stop();

                        valoresSoluciones.Add(r);
                        valoresFitness.Add(f);
                        valoresTiempo.Add(timeMeasure.ElapsedMilliseconds );
                    }

                    break;

                // GENERACIONAL
                case 1:

                    for (int i = 0; i < cantSoluciones; i++)
                    {
                        timeMeasure.Start();

                        (r, f) = AlgortimoGA.AlgoritmoGeneticoGeneracional(
                            10, (int)nupDimension.Value, (int)nupIteraciones.Value,
                            funcionFitness, funcionSeleccion, funcionCruzamiento, (double)nupProbCruzamiento.Value,
                            funcionMutacion, (double)nupProbMutacion.Value);
                        timeMeasure.Stop();

                        valoresSoluciones.Add(r);
                        valoresFitness.Add(f);
                        valoresTiempo.Add(timeMeasure.ElapsedMilliseconds );
                    }

                    break;                 
            }


            rtbResultado.Text = string.Empty;

            rtbResultado.Text += "_______________ * * * V A L O R  F I T N E S S * * * ______________________________";
            rtbResultado.Text += "\nMejor: " + valoresFitness.Min();
            rtbResultado.Text += "\nPeor: " + valoresFitness.Max();
            rtbResultado.Text += "\nPromedio: " + valoresFitness.Average();
  
            double avg = valoresFitness.Average(); 
            double sum = valoresFitness.Sum(d => Math.Pow(d - avg, 2)); 
            double de = Math.Sqrt((sum) / (valoresFitness.Count()));
            rtbResultado.Text += "\nDesviacion Estandar: " + de;



            rtbResultado.Text += "\n\n_______________ * * * T I E M P O   E J E C U C I Ó N * * * ______________________________";
            rtbResultado.Text += "\nMejor: " + valoresTiempo.Min() + " milisegundos";
            rtbResultado.Text += "\nPeor: " + valoresTiempo.Max() + " milisegundos";
            rtbResultado.Text += "\nPromedio: " + valoresTiempo.Average() + " milisegundos";

            avg = valoresTiempo.Average();
            sum = valoresTiempo.Sum(d => Math.Pow(d - avg, 2));
            de = Math.Sqrt((sum) / (valoresTiempo.Count()));
            rtbResultado.Text += "\nDesviacion Estandar: " + de + " milisegundos";


            rtbResultado.Text += "\n\n_______________ * * * S O L U C I O N E S * * * ______________________________";

            for (int i = 0; i < cantSoluciones; i++)
            {
                r = valoresSoluciones[i];
                f = valoresFitness[i];
                t = valoresTiempo[i];
                rtbResultado.Text += "\n" + (i+1) + " - Fitness: + " + f.ToString()  + "   Tiempo: " + t + " milisegundos";
                rtbResultado.Text += "\n" + (i+1) + " - Solucion: ";
                foreach (var item in r.listaDeValoresDeX)
                {
                    rtbResultado.Text += item + ", ";
                }

                rtbResultado.Text += "\n";
            }

           
        }
    }
}
