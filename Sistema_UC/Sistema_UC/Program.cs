using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UnidadeCurricular uc = new UnidadeCurricular();
            var estudante1 = new Estudante {Nome="Clemente" };
            var estudante2 = new Estudante { Nome = "Nsumbo" };
            var estudante3 = new Estudante { Nome = "Zacarias" };
          


            uc.Estudantes.Add(estudante1);
            uc.Estudantes.Add(estudante2);
            uc.Estudantes.Add(estudante3);
           

            uc.Avaliacao.Add(new Teste { Estudante = estudante1, nota = 16, Peso = 0.2 });
            uc.Avaliacao.Add(new Projeto { Estudante = estudante1, nota = 17, Peso = 0.3 });
            uc.Avaliacao.Add(new ExameFinal { Estudante = estudante1, nota = 17, Peso = 0.6 });

            uc.Avaliacao.Add(new Teste { Estudante = estudante2, nota = 17, Peso = 0.2 });
            uc.Avaliacao.Add(new Projeto { Estudante = estudante2, nota = 14, Peso = 0.3 });
            uc.Avaliacao.Add(new ExameFinal { Estudante = estudante2, nota = 19, Peso = 0.6 });

            uc.Avaliacao.Add(new Teste { Estudante = estudante3, nota = 17, Peso = 0.2 });
            uc.Avaliacao.Add(new Projeto { Estudante = estudante3, nota = 17, Peso = 0.3 });
            uc.Avaliacao.Add(new ExameFinal { Estudante = estudante3, nota = 17, Peso = 0.6 });

            uc.EmitirPauta();


        }
    }
}
