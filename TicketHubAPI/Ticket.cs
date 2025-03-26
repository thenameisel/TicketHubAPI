namespace TicketHubAPI
{
    public class Ticket
    {

        //        {
        //  "concertId": 0,
        //  "email": "string",
        //  "name": "string",
        //  "phone": "string",
        //  "quantity": 0,
        //  "creditCard": "string",
        //  "expiration": "string",
        //  "securityCode": "string",
        //  "address": "string",
        //  "city": "string",
        //  "province": "string",
        //  "postalCode": "string",
        //  "country": "string"
        //}
        public int concertId { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public int quantity { get; set; }
        public string creditCard { get; set; }
        public string expiration { get; set; }
        public string securityCode { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }

    }
}
