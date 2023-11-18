﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmaTracker.Server.DAL;
using PharmaTracker.Shared;

namespace PharmaTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public ProductosController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> GetProductos()
        {
          if (_context.Productos == null)
          {
              return NotFound();
          }
            return await _context.Productos.ToListAsync();
        }

        // GET: api/Productos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Productos>> GetProductos(int id)
        {
          if (_context.Productos == null)
          {
              return NotFound();
          }
            var productos = await _context.Productos.FindAsync(id);

            if (productos == null)
            {
                return NotFound();
            }

            return productos;
        }

        // PUT: api/Productos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductos(int id, Productos productos)
        {
            if (id != productos.ProductoId)
            {
                return BadRequest();
            }

            _context.Entry(productos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosExists(id))
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

        // POST: api/Productos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
		public async Task<ActionResult<Productos>> PostProductos(Productos productos)
		{
			if (productos.ProductoId <= 0 || !ProductosExists(productos.ProductoId))
			{
				_context.Productos.Add(productos);
			}
			else
			{
				_context.Productos.Update(productos);
			}

			await _context.SaveChangesAsync();

			return Ok(productos);
		}

        // DELETE: api/Productos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductos(int id)
        {
            if (_context.Productos == null)
            {
                return NotFound();
            }
            var productos = await _context.Productos.FindAsync(id);
            if (productos == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(productos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //Delete: api/Productos
        [HttpDelete("DeleteProductosMes/{id}")]
        public async Task<IActionResult> DeleteProductosMes(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var productosDesc = await _context.DescripcionProductoD.FirstOrDefaultAsync(dp => dp.ProductoId == id);
            var productosComp = await _context.ComponentesProductoD.FirstOrDefaultAsync(cp => cp.ProductoId == id);
            if(productosDesc is not null && productosComp is not null)
            {
                return NotFound();
			}
            _context.DescripcionProductoD.Remove(productosDesc);
            _context.ComponentesProductoD.Remove(productosComp);
            await _context.SaveChangesAsync();

            return Ok();
		}

        private bool ProductosExists(int id)
        {
            return (_context.Productos?.Any(e => e.ProductoId == id)).GetValueOrDefault();
        }
    }
}
