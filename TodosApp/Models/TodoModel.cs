using System.ComponentModel.DataAnnotations;

namespace TodosApp.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}
