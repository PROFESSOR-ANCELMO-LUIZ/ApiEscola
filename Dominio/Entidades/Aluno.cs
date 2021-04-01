using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Aluno
    {
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public int Id { get; private set; }
        public int CursoId { get; private set; }
        public string Nome { get; private set; }
        public string Matricula { get; private set; }

        public Curso Curso { get; private set; }

    }
}
