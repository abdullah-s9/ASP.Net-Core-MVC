using System.ComponentModel.DataAnnotations;

namespace SaudiGuide.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
