using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIPractica.Data;
using APIPractica.Models;

namespace APIPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly PracticaContex _context;

        public ClientesController(PracticaContex context)
        {
            _context = context;
        }
        [HttpGet("{desde}&{hasta}/clientebyedad")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente(int desde, int hasta)
        {
            if (_context.cliente == null)
            {
                return NotFound();
            }
            return await _context.cliente.Where(c => c.edad >= desde && c.edad <= hasta).ToListAsync();
        }

        [HttpGet("{apellido}/clientebyapellido")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente(string apellido)
        {
            IQueryable<Cliente> query = _context.cliente;
            query = query.Where(e => e.apellidos.StartsWith(apellido));
            
            if (query == null)
            {
                return null;
            }
            return await query.ToListAsync();
        }
        [HttpGet("/busquedaporCiudad")]
        public object GetClienteByCiudad(string ciudad)
        {
            if (_context.cliente == null)
            {
                return NotFound();
            }
            var datos = (from e in _context.cliente  join c in _context.ciudad on e.idCiudad equals c.id_ciudad
                             where(c.nombreCiudad == ciudad) select new
                             {
                               cedula=   e.cedula,
                                nombres= e.nombres,
                               apellidos=  e.apellidos,
                               direccion = e.direccion,
                               edad =  e.edad,
                               nombreCiudad = c.nombreCiudad
                             }).ToList();
            return datos;
        }

        [HttpGet("{cedula}/clientebycedula")]
        public async Task<ActionResult<IEnumerable<Cliente>>> Search(string cedula)
        {
            IQueryable<Cliente> query = _context.cliente;
            query = query.Where(e => e.cedula.StartsWith(cedula));
            if (query == null)
            {
                return null;
            }
            return await query.ToListAsync();
        }
        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            if (_context.cliente == null)
            {
                return NotFound();
            }

            return await _context.cliente.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
          if (_context.cliente == null)
          {
              return NotFound();
          }
            var cliente = await _context.cliente.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
          if (_context.cliente == null)
          {
              return Problem("Entity set 'PracticaContex.Clientes'  is null.");
          }
            _context.cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.IdCliente }, cliente);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int? id)
        {
            if (_context.cliente == null)
            {
                return NotFound();
            }
            var cliente = await _context.cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(int? id)
        {
            return (_context.cliente?.Any(e => e.IdCliente == id)).GetValueOrDefault();
        }
    }
}
