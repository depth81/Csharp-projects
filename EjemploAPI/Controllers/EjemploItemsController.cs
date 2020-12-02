﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EjemploAPI.Models;

namespace EjemploAPI.Controllers
{
    [Route("api/EjemploItems")]
    [ApiController]
    public class EjemploItemsController : ControllerBase
    {
        private readonly EjemploContext _context;

        public EjemploItemsController(EjemploContext context)
        {
            _context = context;
        }

        // GET: api/EjemploItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EjemploItem>>> GetEjemploItem()
        {
            return await _context.EjemploItem.ToListAsync();
        }

        // GET: api/EjemploItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EjemploItem>> GetEjemploItem(long id)
        {
            var ejemploItem = await _context.EjemploItem.FindAsync(id);

            if (ejemploItem == null)
            {
                return NotFound();
            }

            return ejemploItem;
        }

        // PUT: api/EjemploItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEjemploItem(long id, EjemploItem ejemploItem)
        {
            if (id != ejemploItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(ejemploItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EjemploItemExists(id))
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

        // POST: api/EjemploItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EjemploItem>> PostEjemploItem(EjemploItem ejemploItem)
        {
            _context.EjemploItem.Add(ejemploItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEjemploItem", new { id = ejemploItem.Id }, ejemploItem);
            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetEjemploItem), new { id = ejemploItem.Id }, ejemploItem);
        }

        // DELETE: api/EjemploItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EjemploItem>> DeleteEjemploItem(long id)
        {
            var ejemploItem = await _context.EjemploItem.FindAsync(id);
            if (ejemploItem == null)
            {
                return NotFound();
            }

            _context.EjemploItem.Remove(ejemploItem);
            await _context.SaveChangesAsync();

            return ejemploItem;
        }

        private bool EjemploItemExists(long id)
        {
            return _context.EjemploItem.Any(e => e.Id == id);
        }
    }
}
