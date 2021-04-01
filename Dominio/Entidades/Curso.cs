using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Curso
    {
        public Curso(string nome, string turno)
        {
            Nome = nome;
            Turno = turno;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Turno { get; private set; }

        public IEnumerable<Aluno> Alunos { get; private set; }
    }
}
