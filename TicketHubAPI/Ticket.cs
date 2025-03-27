using System.ComponentModel.DataAnnotations;

namespace TicketHubAPI
{
    public class Ticket
    {
        [Range(1,200,ErrorMessage = "Valid concert ID required")]
        public int concertId { get; set; }

        [EmailAddress(ErrorMessage = "Valid email required")]
        public string email { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be less than 50 characters")]
        public string name { get; set; }

        [Phone(ErrorMessage = "Valid phone required")]
        public string phone { get; set; }

        [Range(1, 25, ErrorMessage = "Valid quantity required")]
        public int quantity { get; set; }

        [CreditCard(ErrorMessage = "Valid credit card required")]
        public string creditCard { get; set; }

        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Valid expiration required")]
        public string expiration { get; set; }

        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "Security code must be 3 or 4 digits")]
        public string securityCode { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Address must be less than 50 characters")]
        public string address { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "City must be less than 50 characters")]
        public string city { get; set; }

        [StringLength(25, MinimumLength = 2, ErrorMessage = "Province must be less than 25 characters")]
        public string province { get; set; } //I might change this to a dropdown if a UI was implemented

        [RegularExpression(@"^(?i)[a-z]\d[a-z][ -]?\d[a-z]\d(?-i)$", ErrorMessage = "Valid postal code required")]
        public string postalCode { get; set; }

        [Compare("Canada", ErrorMessage = "Sorry, we only sell to Canadians!")]
        public string country { get; set; }

    }
}
