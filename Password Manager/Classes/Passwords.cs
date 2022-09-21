using System;

namespace Password_Manager
{
    public class Passwords
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string Site { get; set; }
        public string Provider { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
