using Microsoft.AspNetCore.Mvc;
using PruebaTropigasAPI.Context;
using PruebaTropigasAPI.Models;

namespace PruebaTropigasAPI.Controllers
{
    [ApiController]
    public class VentasController : Controller
    {
        private readonly TropigasDbContext _context;

        public VentasController(TropigasDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("api/Configuracion")]
        public IActionResult Configuracion()
        {
            return Ok(_context.Configuracion);
        }
        [HttpGet]
        [Route("api/Articulos")]
        public IActionResult GetArticulos()
        {
            return Ok(_context.Articulos);
        }
        [HttpGet]
        [Route("api/Venta")]
        public IActionResult GetVenta()
        {
            return Ok(_context.Venta);
        }
        [HttpGet]
        [Route("api/VentaD")]
        public IActionResult GetVentaD()
        {
            return Ok(_context.VentaD);
        }
        [HttpPost]
        [Route("api/Venta")]
        public async Task<IActionResult> CreateVenta([FromBody] Venta venta)
        {
            await _context.Venta.AddAsync(venta);
            await _context.SaveChangesAsync();

            return Ok(venta);
        }
        [HttpPost]
        [Route("api/VentaD")]
        public async Task<IActionResult> CreateVentaD([FromBody] List<VentaD> ventad)
        {
            foreach (VentaD v in ventad) {
                await _context.VentaD.AddAsync(v);
            }
            
            await _context.SaveChangesAsync();

            return Ok(ventad);
        }
        [HttpPut("api/Venta/{id}")]
        public async Task<IActionResult> UpdateVenta([FromRoute] int id, [FromBody] Venta venta)
        {
            _context.Update(venta);

            await _context.SaveChangesAsync();

            return Ok(venta);
        }
        [HttpPut("api/VentaD/{id}")]
        public async Task<IActionResult> UpdateVentaD([FromRoute] int id, [FromBody] VentaD ventad)
        {
            _context.Update(ventad);

            await _context.SaveChangesAsync();

            return Ok(ventad);
        }
        [HttpDelete("api/Venta/{id}")]
        public async Task<IActionResult> DeleteVenta([FromRoute] string id)
        {
            var venta = await _context.Venta.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            _context.Venta.Remove(venta);
            await _context.SaveChangesAsync();

            return Ok(venta);
        }
        [HttpDelete("api/VentaD/{id}")]
        public async Task<IActionResult> DeleteVentaD([FromRoute] int id)
        {
            var ventad = await _context.Venta.FindAsync(id);

            if (ventad == null)
            {
                return NotFound();
            }

            _context.Venta.Remove(ventad);
            await _context.SaveChangesAsync();

            return Ok(ventad);
        }
    }
}
