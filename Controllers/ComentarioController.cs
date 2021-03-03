using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BEComentarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ComentarioController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ComentarioController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listComentarios = await _context.Comentario.ToListAsync();

                return Ok(listComentarios);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // GET api/<ComentarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ComentarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComentarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComentarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
