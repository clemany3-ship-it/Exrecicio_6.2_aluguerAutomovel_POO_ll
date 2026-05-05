using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_UC
{
    public class Teste:Avaliacao
    {
        public double nota { get; set; }
        public override double CalcularNotaFinal() 
        {
            return nota * Peso;
        
        }
    }
}
