using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Resources
{
    public class ValoresFunciones
    {
        public ValoresFunciones()
        {
            listaDeValoresDeX = new List<float>();
        }
        public int NumDimensiones { get; set; }

        public List<float> listaDeValoresDeX { get; set; }

        public object Clone()
        {
            object obj = this.MemberwiseClone();
            this.listaDeValoresDeX = new List<float>(listaDeValoresDeX);
            return obj;
        }
    }
}
