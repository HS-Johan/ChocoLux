using System.ComponentModel.DataAnnotations;

namespace ChocoLux.DataModels
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }

        public string? TestimonialTitle { get; set; }

        public string? TestimonialDescription { get; set; }

        public string? TestimonialThumbnail {  get; set; }

        public bool TestimonialIsActive { get; set; }
    }
}
