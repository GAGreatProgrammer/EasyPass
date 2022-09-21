using System;

namespace Password_Manager.Classes
{
    public class Notes
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
