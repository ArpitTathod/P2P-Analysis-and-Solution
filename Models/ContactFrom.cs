using System.ComponentModel.DataAnnotations;

namespace P2Psample1.Models
{
    

    public class ContactForm
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string City { get; set; }

        public string InquiryType { get; set; }

        public string Education { get; set; }

        public string Country { get; set; }

        public string Service { get; set; }

        public string Message { get; set; }

        public bool PrivacyPolicy { get; set; }
    }

}