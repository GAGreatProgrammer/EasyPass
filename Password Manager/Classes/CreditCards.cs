using System;

namespace Password_Manager.Classes
{
    public class CreditCards
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string Cardholder_Name { get; set; }
        public string Card_Number { get; set; }
        public string Expiration_Date { get; set; }
        public string CVC_CVV { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
