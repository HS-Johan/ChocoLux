using System.ComponentModel.DataAnnotations;

namespace ChocoLux.DataModels
{
    public class Chocolate
    {
        [Key]
        public int ChocolateId { get; set; }

        public string? ChocolateName { get; set; }

        public double ChocolatePrice { get; set; }

        public string? ChocolateImage { get; set; }

        public int ChocolateAmmount { get; set; }

        public bool ChocolateIsActive { get; set; }
    }
}
