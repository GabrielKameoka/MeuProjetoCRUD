using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuProjetoCRUD.Context;
using MeuProjetoCRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly UsuarioContext _context;

        public ContatoController(UsuarioContext context)
        {
            _context = context;
        }

        [HttpPost("CadastrarUsuário")]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("BuscaPorId")]
        public IActionResult BuscaPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPut("AtualizaPorId")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
            {
                return NotFound();
            }
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Email = contato.Email;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("DeletaPorId")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }

    }
}