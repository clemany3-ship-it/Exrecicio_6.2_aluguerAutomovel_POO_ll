using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_UC
{
    public abstract class Avaliacao:IAvaliavel
    {
        public Estudante Estudante { get; set; }
        public double nota { get; set; }
        public double Peso { get; set; }
        public abstract double CalcularNotaFinal();
    }
}
