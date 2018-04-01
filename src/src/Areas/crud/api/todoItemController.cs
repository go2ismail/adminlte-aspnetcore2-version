using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Areas.crud.Models;
using src.Data;

namespace src.Areas.crud.api
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class todoItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public todoItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/todoItem
        [HttpGet]
        public IEnumerable<todoItem> GettodoItem()
        {
            return _context.todoItem;
        }

        // GET: api/todoItem/5
        [HttpGet]
        public async Task<IActionResult> GettodoItemById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoItem = await _context.todoItem.SingleOrDefaultAsync(m => m.id == id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return Ok(todoItem);
        }

        // PUT: api/todoItem/5
        [HttpPut]
        public async Task<IActionResult> PuttodoItem(todoItem todoItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            

            _context.Entry(todoItem).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/todoItem
        [HttpPost]
        public async Task<IActionResult> PosttodoItem(todoItem todoItem)
        {
           
            _context.todoItem.Add(todoItem);
            await _context.SaveChangesAsync();

            return Ok(todoItem);
        }

        // DELETE: api/todoItem/5
        [HttpDelete]
        public async Task<IActionResult> DeletetodoItem(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoItem = await _context.todoItem.SingleOrDefaultAsync(m => m.id == id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.todoItem.Remove(todoItem);
            await _context.SaveChangesAsync();

            return Ok(todoItem);
        }

        private bool todoItemExists(int id)
        {
            return _context.todoItem.Any(e => e.id == id);
        }
    }
}