using Password_Manager.Classes;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Forms
{
    public partial class Authorization : Form
    {
        static Authorization _object;

        string DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DROPSHADOW;
                return cp;
            }
        }

        public static Authorization Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new Authorization();
                }
                return _object;
            }
        }

        public Authorization()
        {
            InitializeComponent();

            _object = this;
            this.Icon = Properties.Resources.Icon;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bgwEncrypt.RunWorkerCompleted += BgwEncrypt_RunWorkerCompleted;
        }

        private void bgwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            this.btnClose.Enabled = false;
            this.btnLogin.Enabled = false;

            DatabaseProtector.EncryptDatabase();
        }

        private void BgwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GenerateLogs.GeneretaLog("Login form closed");
            Environment.Exit(0);
        }

        private void Login()
        {
            AppSettingsSecurity.DecryptSettings();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                !string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                if (Properties.Settings.Default.Username.Equals(txtUsername.Text) &&
                    Properties.Settings.Default.UserPassword.Equals(GetHash.HashString(txtPassword.Text)))
                {
                    DatabaseProtector.IsDirectoryEmpty();
                    DatabaseProtector.IsFileExists();

                    DatabaseProtector.CheckDatabaseStatus();

                    EasyPass easyPass = new EasyPass();
                    easyPass.Show();

                    txtUsername.Clear();
                    txtPassword.Clear();

                    this.Hide();

                    GenerateLogs.GeneretaLog("User authorized successfully");
                }
                else
                {
                    MessageBox.Show("Wrong data. Try again!", "Error",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

                    GenerateLogs.GeneretaLog($"The entered Username ({txtUsername.Text}) or Password ({txtPassword.Text}) " +
                        $"is incorrect ");

                    txtUsername.Clear();
                    txtPassword.Clear();

                    AppSettingsSecurity.EncryptSettings();
                }
            }

            else if (string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                     string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                MessageBox.Show("User account not found. Unable to Login!", "Warning",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);

                GenerateLogs.GeneretaLog("User account not found. Unable to Login!");
            } 
        }

        private void txtPassword_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.IconRight == Properties.Resources.EyeClose)
            {
                txtPassword.IconRight = Properties.Resources.EyeOpen;
                txtPassword.PasswordChar = '*';
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bgwEncrypt.IsBusy)
            {
                MessageBox.Show("Database encryption operation is running! Please Wait!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.RestrictClosing == true)
            {
                return;
            }
            else if (GlobalVariables.RestrictClosing == false)
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Fill Username and Password fields!", "Warning",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                }

                else if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    Login();
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (GlobalVariables.RestrictClosing == true)
            {
                return;
            }

            else if (GlobalVariables.RestrictClosing == false)
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.Username) && 
                    string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
                {
                    AppSettingsSecurity.EncryptSettings();

                    GenerateLogs.GeneretaLog("Login form closed");
                    Environment.Exit(0);
                }

                else
                {
                    if (GlobalVariables.DatabaseLocked == true)
                    {
                        AppSettingsSecurity.EncryptSettings();

                        GenerateLogs.GeneretaLog("Login form closed");
                        Environment.Exit(0);
                    }

                    else if (GlobalVariables.DatabaseLocked == false)
                    {
                        bgwEncrypt.RunWorkerAsync();
                    }
                }
            }
        }

        private void lblResetAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                !string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Fill Username and Password field!", "Warning",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                }

                else if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    AppSettingsSecurity.DecryptSettings();

                    if (Properties.Settings.Default.Username.Equals(txtUsername.Text) &&
                        Properties.Settings.Default.UserPassword.Equals(GetHash.HashString(txtPassword.Text)))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset your settings? " +
                            "All data will be permanently deleted!",
                            "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                        if (dialogResult == DialogResult.Yes)
                        {
                            Properties.Settings.Default.Username = null;
                            Properties.Settings.Default.UserPassword = null;
                            Properties.Settings.Default.DBPassword = null;

                            Properties.Settings.Default.Save();

                            string[] filePaths = Directory.GetFiles(DB_Path);
                            foreach (string filePath in filePaths)
                            {
                                File.Delete(filePath);
                            }

                            MessageBox.Show("Account reset successfully!",
                                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information);

                            GenerateLogs.GeneretaLog("Account reset successfully");

                            txtUsername.Clear();
                            txtPassword.Clear();
                        }

                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong data. Try again!", "Error",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

                        AppSettingsSecurity.EncryptSettings();
                    }
                }
            }

            else if (string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                     string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                MessageBox.Show("User account not found. Unable to reset data!", "Warning",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);

                GenerateLogs.GeneretaLog("User account not found. Unable to reset data!");
            }
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                this.Hide();

                new Registration().ShowDialog();
            }

            else if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                     !string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                MessageBox.Show("User account already exists. Can't create new account!", "Warning",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);

                GenerateLogs.GeneretaLog("User account exists. Can't create new account!");
            }
        }

        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
