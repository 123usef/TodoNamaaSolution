using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoNamaa.Api.Context;
using TodoNamaa.Api.Models;

namespace TodoNamaa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TodoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Read - Create - Update - Delete ==> 5 Actions
        [HttpGet]
        [ProducesResponseType(statusCode:200)]
        public  ActionResult<IEnumerable<Todo>> getall()
        {
            // Select * from todos ;
            var todos = _dbContext.todos.ToList();

            return Ok(todos);
            //return NOtFound();
            //return BadRequest();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 404)]
        public ActionResult<Todo> get(int id)
        {
            // Select * from todos ;
            var todos = _dbContext.todos.Find(id);
            if(todos is null)
            {
                return NotFound();
            }
            return Ok(todos);
     
        }

        [HttpPost]
        public ActionResult CreateTodo(Todo todo)
        {
            if (todo is not null)
            {
                _dbContext.todos.Add(todo);
                _dbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
                // Accepted 
            //return NoContent();
        }
        [HttpPut]
        public ActionResult UpdateTodo(int id, Todo todo) {

            var tod = _dbContext.todos.Find(id);
            _dbContext.todos.Update(todo);
            _dbContext.SaveChanges();
            return Ok("Updated Successfully ");


        
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var todo = _dbContext.todos.Find(id);
            _dbContext.todos.Remove(todo);
            _dbContext.SaveChanges();
            return Ok($"{todo.Name} is deleted Successfully ");
        }
    }
}
