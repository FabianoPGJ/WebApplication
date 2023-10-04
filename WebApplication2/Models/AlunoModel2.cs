using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel2
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public int Faltas { get; set; }

        public AlunoModel2()
        {
            Nome = "Fabiano";
            Curso = "Desenvolvimento de Sistemas";
            Faltas = 1;
            Matricula = new DateTime(2023,1,27);
        }

        public static AlunoModel2 CriarAluno()
        {
            var aluno = new AlunoModel2();
            aluno.Nome = "Gabriel Gassner";
            return aluno;
        }
        public static List<AlunoModel2> CriarLista()
        {
            var lista = new List<AlunoModel2>();
           // lista.Add(new AlunoModel2());
           // lista.Add(AlunoModel2.CriarAluno());
           lista.Add(new AlunoModel2() { Nome= "Dabiel Neri", Curso = "DS", Faltas = 4, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Jackson", Curso = "DS", Faltas = 2, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Rodrigo", Curso = "DS", Faltas = 1, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Paola", Curso = "DS", Faltas = 3, Matricula = DateTime.Now});

            return lista;
        }
    }
}