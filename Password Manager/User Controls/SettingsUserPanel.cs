using Password_Manager.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class SettingsUserPanel : UserControl
    {
        string DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";

        string Logs_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Logs\{DateTime.Now.ToString("dd.MM.yyyy")}_Logs.log";

        private static SettingsUserPanel _instance;

        public static SettingsUserPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsUserPanel();
                return _instance;
            }
        }

        public SettingsUserPanel()
        {
            InitializeComponent();
        }


        private void SettingsUserPanel_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Logs_File))
                {
                    txtLogs.ForeColor = Color.Black;
                    txtLogs.Text = File.ReadAllText(Logs_File);
                }
                else
                {
                    txtLogs.ForeColor = Color.Red;
                    txtLogs.Text = "Unable to load log data!!!";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        private void SavePassword()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtDBPass.Text) ||
                string.IsNullOrEmpty(txtConfirmDBPass.Text))
            {
                MessageBox.Show("Fill all necessary fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!string.IsNullOrEmpty(txtUsername.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.UserPassword = GetHash.HashString(txtPassword.Text);

                Properties.Settings.Default.Save();

                txtUsername.Clear();
                txtPassword.Clear();


                MessageBox.Show("User data saved!", "EasyPass", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateLogs.GeneretaLog("User data saved!");
            }

            else if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and App Password cannot be empty!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (txtDBPass.Text == txtConfirmDBPass.Text)
            {
                Properties.Settings.Default.DBPassword = txtDBPass.Text;

                Properties.Settings.Default.Save();

                txtDBPass.Clear();
                txtConfirmDBPass.Clear();

                MessageBox.Show("Database password saved!", "EasyPass", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDBPass.Text != txtConfirmDBPass.Text)
            {
                MessageBox.Show("Database passwords do not match. Try again!", 
                    "Match error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            SavePassword();
        }

        private void btnDefaultPassword_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset your data to factory settings? " +
                "In this case, the Username, Application password and Database password will be: EasyPass",
                            "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Username = "EasyPass";
                Properties.Settings.Default.UserPassword = GetHash.HashString("EasyPass");
                Properties.Settings.Default.DBPassword = "EasyPass";

                Properties.Settings.Default.Save();

                MessageBox.Show("Account data successfully reset to factory settings!",
                                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information);

                GenerateLogs.GeneretaLog("Account data successfully reset to factory settings!");
            }

            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GeneratePassword.RandomPassword(15);
        }

        private void btnGenerateDBPassword_Click_1(object sender, EventArgs e)
        {
            txtDBPass.Text = GeneratePassword.RandomPassword(20);
            txtConfirmDBPass.Text = txtDBPass.Text;
        }

        private void txtLogs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (File.Exists(Logs_File))
                {
                    txtLogs.ForeColor = Color.Black;
                    txtLogs.Text = File.ReadAllText(Logs_File);
                }
                else
                {
                    txtLogs.ForeColor = Color.Red;
                    txtLogs.Text = "Unable to load log data!!!";
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
