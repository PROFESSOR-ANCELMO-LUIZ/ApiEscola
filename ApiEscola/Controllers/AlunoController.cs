using ApiEscola.Factories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEscola.Controllers
{
    [ApiController]
    [Route("api/escola")]
    public class AlunoController : Controller
    {
        //https://localhost:5000/api/escola/alunos
        [HttpGet("alunos")]
        public IActionResult ListarTodosAluno()
        {
            var alunos = AlunoFactory.Listar();
            if (alunos != null)
            {
                return Ok(alunos);
            }

            return BadRequest(new { msg = "Nenhum aluno na lista" });
        }

        //https://localhost:5000/api/escola/aluno/1
        [HttpGet("aluno/{id}")]
        public IActionResult BuscarAlunoPeloId(int id)
        {
            var alunos = AlunoFactory.Listar();
            var aluno = AlunoFactory.Buscar(ref alunos, id);

            if (aluno != null)
            {
                return Ok(aluno);
            }

            return BadRequest(new { msg = "Aluno não encontrado" });
        }


    }
}
