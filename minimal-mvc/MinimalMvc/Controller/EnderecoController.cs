using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalMvc.Model;

namespace MinimalMvc.Controller
{
    [Route("/endereco")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private MinimalMvcDb database;
        
        public EnderecoController(MinimalMvcDb database)
        {
            this.database = database;
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> PostEndereco(Endereco endereco)
        {
            var pessoa = await database.Pessoas.FindAsync(endereco.PessoaId);
            if (pessoa == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            database.Enderecos.Add(endereco);
            await database.SaveChangesAsync();

            return CreatedAtAction("GetEndereco", new { id = endereco.EnderecoId }, endereco);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetEndereco(int id)
        {
            var endereco = await database.Enderecos.FirstOrDefaultAsync(e => e.EnderecoId == id);

            if (endereco == null)
            {
                return NotFound();
            }

            return endereco;
        }
    }
}