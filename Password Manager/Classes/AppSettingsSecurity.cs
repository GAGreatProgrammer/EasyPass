using Password_Manager.Properties;
using System;

namespace Password_Manager.Classes
{
    public static class AppSettingsSecurity
    {
        public static void EncryptSettings()
        {
            try
            {
                if (!string.IsNullOrEmpty(Settings.Default.Username) &&
                    !string.IsNullOrEmpty(Settings.Default.UserPassword) &&
                    !string.IsNullOrEmpty(Settings.Default.DBPassword))
                {
                    Settings.Default.Username = Encrypt.TextEncrypt(Settings.Default.Username, Settings.Default.UserPassword);
                    Settings.Default.DBPassword = Encrypt.TextEncrypt(Settings.Default.DBPassword, Settings.Default.UserPassword);

                    Settings.Default.Save();
                }
                else
                {

                }
                
            }
            catch (Exception ex)
            {
                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public static void DecryptSettings()
        {
            try
            {
                if (!string.IsNullOrEmpty(Settings.Default.Username) &&
                    !string.IsNullOrEmpty(Settings.Default.UserPassword) &&
                    !string.IsNullOrEmpty(Settings.Default.DBPassword))
                {
                    Settings.Default.Username = Decrypt.TextDecrypt(Settings.Default.Username, Settings.Default.UserPassword);
                    Settings.Default.DBPassword = Decrypt.TextDecrypt(Settings.Default.DBPassword, Settings.Default.UserPassword);

                    Settings.Default.Save();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                GenerateLogs.GeneretaLog(ex.Message);
            }  
        }
    }
}
