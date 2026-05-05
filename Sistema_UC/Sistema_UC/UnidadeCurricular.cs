using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_UC
{
    public class UnidadeCurricular
    {
        public string Nome { get; set; }

        public List<Estudante> Estudantes { get; set; } = new List<Estudante>();
        public List<Avaliacao> Avaliacao { get; set; } = new List<Avaliacao>();
        public double CalcularMediaFinsl()
        {
            return Avaliacao.Sum(a => a.CalcularNotaFinal());
        }
        public void EmitirPauta()
        {

            foreach (var e in Estudantes)
            {
                double total = 0;
                foreach (var a in Avaliacao)
                {
                    if (a.Estudante == e)
                    {
                        total += a.CalcularNotaFinal();

                    }

                }
                System.Console.WriteLine("O estudante " + e.Nome + " teve o total : " + total);
            }
        }
    }
}