using ApiEscola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEscola.Factories
{
    public static class AlunoFactory
    {
        public static IList<AlunoViewModel> Listar()
        {
            var alunos = new List<AlunoViewModel>();

            alunos.Add(new AlunoViewModel { Id = 1, Nome = "Douglas", Matricula = "1010" });
            alunos.Add(new AlunoViewModel { Id = 2, Nome = "Billy", Matricula = "1015" });
            alunos.Add(new AlunoViewModel { Id = 3, Nome = "Felipe Zomer", Matricula = "1020" });
            alunos.Add(new AlunoViewModel { Id = 4, Nome = "Taiz Perez", Matricula = "2020" });
            alunos.Add(new AlunoViewModel { Id = 5, Nome = "Yann", Matricula = "5025" });

            return alunos;
        }

        public static AlunoViewModel Buscar(ref IList<AlunoViewModel> alunos, int id)
        {
            var aluno = alunos.FirstOrDefault(x => x.Id == id);

            return aluno;
        }
    }
}
