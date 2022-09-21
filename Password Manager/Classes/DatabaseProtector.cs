using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager.Classes
{
    public static class DatabaseProtector
    {
        private static readonly string App_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass";

        private static readonly string Logs_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Logs";


        private static readonly string DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";

        private static readonly string DB_Password_Encrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json.aes";
        private static readonly string DB_Password_Decrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";

        private static readonly string DB_CreditCards_Encrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json.aes";
        private static readonly string DB_CreditCards_Decrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";

        private static readonly string DB_PersonalInfo_Encrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json.aes";
        private static readonly string DB_PersonalInfo_Decrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";

        private static readonly string DB_Notes_Encrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json.aes";
        private static readonly string DB_Notes_Decrypted_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";


        private static void PasswordDatabaseEncrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";

                Encrypt.FileEncrypt(DB_Path, password);

                if (File.Exists(DB_Path + ".aes"))
                {
                    File.Delete(DB_Path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        private static void PasswordDatabaseDecrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";

                Decrypt.FileDecrypt(DB_Path + ".aes", DB_Path, password);

                if (File.Exists(DB_Path))
                {
                    File.Delete(DB_Path + ".aes");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }



        private static void CreditCardsDatabaseEncrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";

                Encrypt.FileEncrypt(DB_Path, password);

                if (File.Exists(DB_Path + ".aes"))
                {
                    File.Delete(DB_Path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        private static void CreditCardsDatabaseDecrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";

                Decrypt.FileDecrypt(DB_Path + ".aes", DB_Path, password);

                if (File.Exists(DB_Path))
                {
                    File.Delete(DB_Path + ".aes");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }



        private static void PersonalInfoDatabaseEncrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";

                Encrypt.FileEncrypt(DB_Path, password);

                if (File.Exists(DB_Path + ".aes"))
                {
                    File.Delete(DB_Path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        private static void PersonalInfoDatabaseDecrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";

                Decrypt.FileDecrypt(DB_Path + ".aes", DB_Path, password);

                if (File.Exists(DB_Path))
                {
                    File.Delete(DB_Path + ".aes");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }



        private static void NotesDatabaseEncrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";

                Encrypt.FileEncrypt(DB_Path, password);

                if (File.Exists(DB_Path + ".aes"))
                {
                    File.Delete(DB_Path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        private static void NotesDatabaseDecrypt()
        {
            try
            {
                string password = Properties.Settings.Default.DBPassword;

                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";

                Decrypt.FileDecrypt(DB_Path + ".aes", DB_Path, password);

                if (File.Exists(DB_Path))
                {
                    File.Delete(DB_Path + ".aes");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }


        public static void EncryptDatabase()
        {
            try
            {
                if (File.Exists(DB_Password_Encrypted_File) && 
                    File.Exists(DB_CreditCards_Encrypted_File) && 
                    File.Exists(DB_PersonalInfo_Encrypted_File) && 
                    File.Exists(DB_Notes_Encrypted_File))
                {
                    GlobalVariables.DatabaseLocked = true;
                    return;
                }

                else if (!File.Exists(DB_Password_Encrypted_File) &&
                         !File.Exists(DB_CreditCards_Encrypted_File) &&
                         !File.Exists(DB_PersonalInfo_Encrypted_File) &&
                         !File.Exists(DB_Notes_Encrypted_File))
                {
                    PasswordDatabaseEncrypt();
                    CreditCardsDatabaseEncrypt();
                    PersonalInfoDatabaseEncrypt();
                    NotesDatabaseEncrypt();

                    GlobalVariables.DatabaseLocked = false;

                    AppSettingsSecurity.EncryptSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public static void DecryptDatabase()
        {
            try
            {
                if (File.Exists(DB_Password_Decrypted_File) &&
                    File.Exists(DB_CreditCards_Decrypted_File) &&
                    File.Exists(DB_PersonalInfo_Decrypted_File) &&
                    File.Exists(DB_Notes_Decrypted_File))
                {
                    GlobalVariables.DatabaseLocked = false;
                    return;
                }

                else if (!File.Exists(DB_Password_Decrypted_File) &&
                         !File.Exists(DB_CreditCards_Decrypted_File) &&
                         !File.Exists(DB_PersonalInfo_Decrypted_File) &&
                         !File.Exists(DB_Notes_Decrypted_File))
                {
                    PasswordDatabaseDecrypt();
                    CreditCardsDatabaseDecrypt();
                    PersonalInfoDatabaseDecrypt();
                    NotesDatabaseDecrypt();

                    GlobalVariables.DatabaseLocked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }


        public static void IsDirectoryEmpty()
        {
            try
            {
                if (!Directory.Exists(App_Path))
                {
                    Directory.CreateDirectory(App_Path); 
                }


                if (!Directory.Exists(DB_Path))
                {
                    Directory.CreateDirectory(DB_Path);
                }


                if (!Directory.Exists(Logs_Path))
                {
                    Directory.CreateDirectory(Logs_Path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public static void IsFileExists()
        {
            try
            {
                AddRecord addRecord = new AddRecord();

                if (File.Exists(DB_Password_Encrypted_File) &&
                    File.Exists(DB_CreditCards_Encrypted_File) &&
                    File.Exists(DB_PersonalInfo_Encrypted_File) &&
                    File.Exists(DB_Notes_Encrypted_File))
                {
                    return;
                }

                else if (!File.Exists(DB_Password_Encrypted_File) &&
                        !File.Exists(DB_CreditCards_Encrypted_File) &&
                        !File.Exists(DB_PersonalInfo_Encrypted_File) &&
                        !File.Exists(DB_Notes_Encrypted_File))
                {
                    if (!File.Exists(DB_Password_Decrypted_File))
                    {
                        File.AppendAllText(DB_Password_Decrypted_File, "{}");

                        addRecord.AddPassword("Test Password", "www.google.com", "Chrome", "User", "Password");
                    }

                    if (!File.Exists(DB_CreditCards_Decrypted_File))
                    {
                        File.AppendAllText(DB_CreditCards_Decrypted_File, "{}");

                        addRecord.AddCreditCard("Test Credit Card", "John Dow", "1234 5678 9876 5432", "00/00",
                            "123", "1234567890");
                    }

                    if (!File.Exists(DB_PersonalInfo_Decrypted_File))
                    {
                        File.AppendAllText(DB_PersonalInfo_Decrypted_File, "{}");

                        addRecord.AddPersonalInfo("Test Personal Information", "John", "Dow");
                    }

                    if (!File.Exists(DB_Notes_Decrypted_File))
                    {
                        File.AppendAllText(DB_Notes_Decrypted_File, "{}");

                        addRecord.AddNote("Test Note", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public static void CheckDatabaseStatus()
        {
            try
            {
                if (File.Exists(DB_Password_Encrypted_File) &&
                    File.Exists(DB_CreditCards_Encrypted_File) &&
                    File.Exists(DB_PersonalInfo_Encrypted_File) &&
                    File.Exists(DB_Notes_Encrypted_File))
                {
                    GlobalVariables.DatabaseLocked = true;
                }

                else if (!File.Exists(DB_Password_Encrypted_File) &&
                         !File.Exists(DB_CreditCards_Encrypted_File) &&
                         !File.Exists(DB_PersonalInfo_Encrypted_File) &&
                         !File.Exists(DB_Notes_Encrypted_File))
                {
                    GlobalVariables.DatabaseLocked = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }
    }
}
