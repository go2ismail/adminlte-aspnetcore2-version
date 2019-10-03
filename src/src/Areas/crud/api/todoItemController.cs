using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Areas.crud.Models;
using src.Data;

namespace src.Areas.crud.api
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class TodoItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/todoItem
        [HttpGet]
        public IEnumerable<todoItem> GettodoItem()
        {
            return _context.TodoItem;
        }

        // GET: api/todoItem/5
        [HttpGet]
        public async Task<IActionResult> GettodoItemById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoItem = await _context.TodoItem.SingleOrDefaultAsync(m => m.id == id);

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

            _context.TodoItem.Add(todoItem);
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

            var todoItem = await _context.TodoItem.SingleOrDefaultAsync(m => m.id == id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();

            return Ok(todoItem);
        }

        private bool TodoItemExists(int id)
        {
            return _context.TodoItem.Any(e => e.id == id);
        }
    }
}