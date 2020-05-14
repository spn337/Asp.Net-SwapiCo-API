using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAPICO.Entities
{
    [Table("tblStarships")]
    public class DbStarship
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string URL { get; set; }
    }
}
