

using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Todo(string title)
        {
            IsComplete = false;
            Title = title;
            Description = "";
            DueDate = DateTime.Now;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Priority = 1;
            Id = Guid.NewGuid();
        }
    }
}