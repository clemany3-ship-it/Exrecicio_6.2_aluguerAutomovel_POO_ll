using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_UC
{
    public class ExameFinal:Avaliacao
    {
        public double Nota {  get; set; }
        public override double CalcularNotaFinal()
        {
            return Nota * Peso;

        }
    }
}
