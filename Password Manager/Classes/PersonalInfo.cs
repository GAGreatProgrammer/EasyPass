using System;

namespace Password_Manager.Classes
{
    public class PersonalInfo
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Organization { get; set; }
        public string Organization_Title { get; set; }
        public string PhoneWork { get; set; }
        public string PhonePrivate { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string Notes { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
