using System.ComponentModel.DataAnnotations;

namespace Portfolio.MVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Conteúdo")]
        public string Content { get; set; }
        [Display(Name = "Data de Criação")]
        public DateTime CreatedAt { get; set; }
    }
}
