using BlazorApp.Server.Data;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ApplicationContext context;

        public PessoaController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> Get()
        {
            return await this.context.Pessoas.ToListAsync();
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Pessoa>> Get(int id)
        {
            return await this.context.Pessoas.FindAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pessoa pessoa)
        {
            await this.context.Pessoas.AddAsync(pessoa);
            await this.context.SaveChangesAsync();

            return new CreatedAtRouteResult(nameof(Get), new { id = pessoa.Id }, pessoa);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Pessoa pessoa)
        {
            this.context.Pessoas.Update(pessoa);
            await this.context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pessoa = await this.context.Pessoas.FindAsync(id);
            this.context.Pessoas.Remove(pessoa);
            await this.context.SaveChangesAsync();

            return NoContent();
        }
    }
}