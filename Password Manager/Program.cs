using Password_Manager.Classes;
using Password_Manager.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Password_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(GlobalException);

            Application.Run(new Authorization());
        }

        static void GlobalException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GenerateLogs.GeneretaLog(e.Exception.Message);
        }
    }
}
