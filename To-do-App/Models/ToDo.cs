using System.ComponentModel.DataAnnotations;

namespace To_do_App.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Task Name.")]
        public string Task { get; set; }
        [Required(ErrorMessage ="Please enter Description For Task.")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please enter DueDate.")]
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage ="Please enter Category of Task.")]
        public string Category { get; set; }
        [Required(ErrorMessage ="Please enter Status of Task.")]
        public string Status { get; set; }

    }
}
