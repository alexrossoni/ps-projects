using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalMvc.Model;

namespace MinimalMvc.Controller
{
    [Route("/pessoa")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private MinimalMvcDb database;
        
        public PessoaController(MinimalMvcDb database)
        {
            this.database = database;
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            database.Pessoas.Add(pessoa);
            await database.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPessoa), new { id = pessoa.PessoaId }, pessoa);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoa = await database.Pessoas.Include(p => p.Enderecos).FirstOrDefaultAsync(p => p.PessoaId == id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return pessoa;
        }
    }
}