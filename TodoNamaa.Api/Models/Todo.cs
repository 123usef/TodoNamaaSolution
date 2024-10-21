using System.ComponentModel.DataAnnotations.Schema;

namespace TodoNamaa.Api.Models
{
    public class Todo
    {
        public  int id { get; set; } // by default the class member is private 
        public string Name { get; set; }
        public string  Description { get; set; }
        public DateOnly Deadline { get; set; }
        //by Converntion
        //public int CategoryId { get; set; }
        //[ForeignKey(nameof(Todo.Category))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; } // Navigational Property 

        //TODO.cATEGORY.NAME
    }
}
