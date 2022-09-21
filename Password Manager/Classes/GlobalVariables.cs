namespace Password_Manager.Classes
{
    public class GlobalVariables
    {
        public static bool DatabaseLocked { get; set; } = true;
        public static bool RestrictClosing { get; set; } = false;


        public static bool PasswordReadMode { get; set; } = false;
        public static bool CreditCardReadMode { get; set; } = false;
        public static bool PersonalInfoReadMode { get; set; } = false;
        public static bool NoteReadMode { get; set; } = false;


        public static int PasswordID { get; set; }
        public static int CreditCardID { get; set; }
        public static int PersonalInfoID { get; set; }
        public static int NoteID { get; set; }
    }
}
