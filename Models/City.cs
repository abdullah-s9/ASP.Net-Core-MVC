using System.ComponentModel.DataAnnotations;

namespace SaudiGuide.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
    }
}
