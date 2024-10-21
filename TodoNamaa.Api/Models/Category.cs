using System.ComponentModel.DataAnnotations;

namespace TodoNamaa.Api.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required] //Data Annotation
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Todo> Todo { get; set; } = new HashSet<Todo>();
    }
}
