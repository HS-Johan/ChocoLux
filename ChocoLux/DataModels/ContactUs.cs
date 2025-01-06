using System.ComponentModel.DataAnnotations;

namespace ChocoLux.DataModels
{
    public class ContactUs
    {
        [Key]
        public int ContactId { get; set; }

        public string? ContactName { get; set; }

        public string? ContactPhone { get; set; }

        public string? ContactEmail { get; set; }

        public string? ContactMessage { get; set; }

    }
}
