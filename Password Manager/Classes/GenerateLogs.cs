using System;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Classes
{
    public static class GenerateLogs
    {
        public static void GeneretaLog(string log)
        {
            try
            {
                var Logs_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Logs\{DateTime.Now.ToString("dd.MM.yyyy")}_Logs.log";

                if (!File.Exists(Logs_File))
                {
                    File.AppendAllText(Logs_File, $"[{DateTime.Now}] - Logs file created.{Environment.NewLine}");
                }

                File.AppendAllText(Logs_File, $"[{DateTime.Now}] - {log}.{Environment.NewLine}");
            }

            catch
            {

            }
        }
    }
} 
