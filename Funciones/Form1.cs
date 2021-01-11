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
            cmbMetMutacion.SelectedIndex = 0;
        }

 

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AlgortimoGA.FuncionFitness funcionFitness = Funcion.Alpine;
            AlgortimoGA.FuncionSeleccion funcionSeleccion = MetodosSeleccion.Proporcional;
            AlgortimoGA.FuncionCruzamiento funcionCruzamiento = MetodosCruzamiento.CruzamientoArimetico;
            AlgortimoGA.FuncionMutacion funcionMutacion = MetodosMutacion.MutacionRealesOptimo;
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
                    funcionFitness = Funcion.Alpine;
                    break;
                case 1:
                    funcionFitness = Funcion.Dixon_Price;
                    break;
                case 2:
                    funcionFitness = Funcion.Quintic;
                    break;
                case 3:
                    funcionFitness = Funcion.Schwefel;
                    break;
                case 4:
                    funcionFitness = Funcion.Streched_V;
                    break;
                case 5:
                    funcionFitness = Funcion.Suma_Cuadrados;
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

            switch ( cmbMetMutacion.SelectedIndex )
            {
                case 0:
                    funcionMutacion = MetodosMutacion.MutacionRealesOptimo;
                    break;
                case 1:
                    funcionMutacion = MetodosMutacion.MutacionRealesAleatorio;
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
                            10, (int)nupDimension.Value, (int)nupIteraciones.Value, (int)nupEvaluaciones.Value,
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
                            10, (int)nupDimension.Value, (int)nupIteraciones.Value, (int)nupEvaluaciones.Value,
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

            

            

            float[] temp = valoresFitness.ToArray();
            Array.Sort(temp);
            int count = temp.Length;
            float mediana;
            if (count % 2 == 0)
            {
                // count is even, average two middle elements
                float a = temp[count / 2 - 1];
                float b = temp[count / 2];
                rtbResultado.Text += "\nMediana: " +  (a + b) / 2;
                mediana = (a + b) / 2;
            }
            else
            {
                // count is odd, return the middle element
                rtbResultado.Text += "\nMediana: " + temp[count / 2];
                mediana = temp[count / 2];
            }
            

            double avg = valoresFitness.Average(); 
            double sum = valoresFitness.Sum(d => Math.Pow(d - avg, 2)); 
            double de = Math.Sqrt((sum) / (valoresFitness.Count()));
            rtbResultado.Text += "\nDesviacion Estandar: " + de;

            //Se agrega renglon
            int n = dataGridResultados.Rows.Add();
            //Se coloca la informacion
            dataGridResultados.Rows[n].Cells[0].Value = cmbFuncion.Text;
            dataGridResultados.Rows[n].Cells[1].Value = valoresFitness.Min();
            dataGridResultados.Rows[n].Cells[2].Value = valoresFitness.Max();
            dataGridResultados.Rows[n].Cells[3].Value = valoresFitness.Average();
            dataGridResultados.Rows[n].Cells[4].Value = mediana;
            dataGridResultados.Rows[n].Cells[5].Value = de;



            rtbResultado.Text += "\n\n_______________ * * * T I E M P O   E J E C U C I Ó N * * * ______________________________";
            rtbResultado.Text += "\nMejor: " + valoresTiempo.Min() + " milisegundos";
            rtbResultado.Text += "\nPeor: " + valoresTiempo.Max() + " milisegundos";
            rtbResultado.Text += "\nPromedio: " + valoresTiempo.Average() + " milisegundos";

            temp = valoresTiempo.ToArray();
            Array.Sort(temp);
            count = temp.Length;
            if (count % 2 == 0)
            {
                // count is even, average two middle elements
                float a = temp[count / 2 - 1];
                float b = temp[count / 2];
                rtbResultado.Text += "\nMediana: " + (a + b) / 2;
                mediana= (a + b) / 2;
            }
            else
            {
                // count is odd, return the middle element
                rtbResultado.Text += "\nMediana: " + temp[count / 2];
                mediana= temp[count / 2];
            }
            

            avg = valoresTiempo.Average();
            sum = valoresTiempo.Sum(d => Math.Pow(d - avg, 2));
            de = Math.Sqrt((sum) / (valoresTiempo.Count()));
            rtbResultado.Text += "\nDesviacion Estandar: " + de + " milisegundos";

            //Se agrega renglon
            n = dataGridTiempo.Rows.Add();
            //Se coloca la informacion
            dataGridTiempo.Rows[n].Cells[0].Value = cmbFuncion.Text;
            dataGridTiempo.Rows[n].Cells[1].Value = valoresTiempo.Min();
            dataGridTiempo.Rows[n].Cells[2].Value = valoresTiempo.Max();
            dataGridTiempo.Rows[n].Cells[3].Value = valoresTiempo.Average();
            dataGridTiempo.Rows[n].Cells[4].Value = mediana;
            dataGridTiempo.Rows[n].Cells[5].Value = de;


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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridResultados.Rows.Clear();
            dataGridTiempo.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridResultados.Rows.RemoveAt(dataGridResultados.CurrentRow.Index);
            dataGridTiempo.Rows.RemoveAt(dataGridResultados.CurrentRow.Index);
        }
    }


    
}
