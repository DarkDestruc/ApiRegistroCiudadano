using ApiRegistroCiudadano.Data;
using ApiRegistroCiudadano.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiRegistroCiudadano.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ApiRegistroCiudadanoDbContext _context;

        public RegisterController(ApiRegistroCiudadanoDbContext context)
        { 
        _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<RegistroNuevo>> PostPersona(RegistroNuevo registroNuevo)
        { 
        _context.registroNuevos.Add(registroNuevo);
        await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = registroNuevo.ID }, registroNuevo);
        
        }
    }

}
