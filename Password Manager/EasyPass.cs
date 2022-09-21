using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Password_Manager.Classes;
using Password_Manager.User_Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class EasyPass : Form
    {
        static EasyPass _object;

        public static EasyPass Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new EasyPass();
                }
                return _object;
            }
        }

        public BunifuButton PersonalInfo
        {
            get { return btnPersonalInfo; }
            set { btnPersonalInfo = value; }
        }

        public Panel Panel
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }

        public EasyPass()
        {
            InitializeComponent();
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }



        private void EasyPass_Load(object sender, EventArgs e)
        {
            GenerateLogs.GeneretaLog("EasyPass opened");

            DatabaseProtector.CheckDatabaseStatus();

            GlobalVariables.RestrictClosing = true;

            this.Icon = Properties.Resources.Icon;
            notifyIcon.Icon = Properties.Resources.Icon;

            notifyIcon.Visible = false;

            _object = this;

            if (!ContentPanel.Controls.Contains(WelcomeScreen.Instance))
            {
                ContentPanel.Controls.Add(WelcomeScreen.Instance);
                WelcomeScreen.Instance.Dock = DockStyle.Fill;
                WelcomeScreen.Instance.BringToFront();
            }

            else
            {
                WelcomeScreen.Instance.BringToFront();
            }


            btnClose.Enabled = false;

            txtSearch.Enabled = false;

            btnPasswords.Enabled = false;
            btnCredisCards.Enabled = false;
            btnPersonalInfo.Enabled = false;
            btnSecureNotes.Enabled = false;

            btnSettings.Enabled = false;
            btnLock.Enabled = false;
            btnLogOut.Enabled = false;

            WelcomeScreen.Instance.Loader.Visible = true;
            WelcomeScreen.Instance.LoadingInfo.Visible = true;

            WelcomeScreen.Instance.LoadingInfo.Text = "Database is being decrypted. Wait, please...";

            bgwDecrypt.RunWorkerCompleted += bgwDecrypt_RunWorkerCompleted;
            bgwEncrypt.RunWorkerCompleted += BgwEncrypt_RunWorkerCompleted;
            bgwLock.RunWorkerCompleted += BgwLock_RunWorkerCompleted;

            bgwDecrypt.RunWorkerAsync(); 
        }


        private void bgwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerateLogs.GeneretaLog("Decrypting database...");

            DatabaseProtector.DecryptDatabase();
        }

        private void bgwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerateLogs.GeneretaLog("Encrypting database...");

            DatabaseProtector.EncryptDatabase();
        }

        private void bgwLock_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerateLogs.GeneretaLog("Encrypting database...");
            GenerateLogs.GeneretaLog("Locking app...");

            DatabaseProtector.EncryptDatabase();
        }

        private void bgwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GenerateLogs.GeneretaLog("Database successfully decrypted");

            DatabaseProtector.CheckDatabaseStatus();

            GlobalVariables.RestrictClosing = false;

            btnClose.Enabled = true;

            txtSearch.Enabled = true;

            btnPasswords.Enabled = true;
            btnCredisCards.Enabled = true;
            btnPersonalInfo.Enabled = true;
            btnSecureNotes.Enabled = true;

            btnSettings.Enabled = true;
            btnLock.Enabled = true;
            btnLogOut.Enabled = true;
            

            WelcomeScreen.Instance.Loader.Visible = false;
            WelcomeScreen.Instance.LoadingInfo.Visible = false;

            DBStatusSnackbar.Show(this, "Database successfully decrypted!", BunifuSnackbar.MessageTypes.Success, 
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
        }

        private void BgwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GenerateLogs.GeneretaLog("EasyPass closed");

            Environment.Exit(0);
        }

        private void BgwLock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                GenerateLogs.GeneretaLog("Database successfully encrypted");

                DatabaseProtector.CheckDatabaseStatus();

                GlobalVariables.RestrictClosing = false;

                this.btnClose.Enabled = true;

                WelcomeScreen.Instance.Loader.Visible = false;
                WelcomeScreen.Instance.LoadingInfo.Visible = false;

                DBStatusSnackbar.Show(this, "Database successfully encrypted!", BunifuSnackbar.MessageTypes.Success,
                    duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.DatabaseLocked == true)
            {
                GenerateLogs.GeneretaLog("EasyPass closed");

                Environment.Exit(0);
            }

            else if (GlobalVariables.DatabaseLocked == false)
            {
                GlobalVariables.RestrictClosing = true;
                GlobalVariables.DatabaseLocked = true;

                btnClose.Enabled = false;
                btnSettings.Enabled = false;
                btnLock.Enabled = false;
                btnLogOut.Enabled = false;

                txtSearch.Enabled = false;

                btnPasswords.Enabled = false;
                btnCredisCards.Enabled = false;
                PersonalInfo.Enabled = false;
                btnSecureNotes.Enabled = false;


                if (!ContentPanel.Controls.Contains(WelcomeScreen.Instance))
                {
                    ContentPanel.Controls.Add(WelcomeScreen.Instance);
                    WelcomeScreen.Instance.Dock = DockStyle.Fill;
                    WelcomeScreen.Instance.BringToFront();
                }

                else
                {
                    WelcomeScreen.Instance.BringToFront();
                }

                WelcomeScreen.Instance.Loader.Visible = true;
                WelcomeScreen.Instance.LoadingInfo.Visible = true;

                WelcomeScreen.Instance.LoadingInfo.Text = "Database is being encrypted. Wait, please...";


                bgwEncrypt.RunWorkerAsync();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
           

        private void btnPasswords_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(PasswordsPanel.Instance))
                {
                    ContentPanel.Controls.Add(PasswordsPanel.Instance);
                    PasswordsPanel.Instance.Dock = DockStyle.Fill;
                    PasswordsPanel.Instance.BringToFront();
                }

                else
                {
                    PasswordsPanel.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        private void btnCredisCards_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(CreditCardsPanel.Instance))
                {
                    ContentPanel.Controls.Add(CreditCardsPanel.Instance);
                    CreditCardsPanel.Instance.Dock = DockStyle.Fill;
                    CreditCardsPanel.Instance.BringToFront();
                }

                else
                {
                    CreditCardsPanel.Instance.BringToFront();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        private void btnSecureNotes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(NotesPanel.Instance))
                {
                    ContentPanel.Controls.Add(NotesPanel.Instance);
                    NotesPanel.Instance.Dock = DockStyle.Fill;
                    NotesPanel.Instance.BringToFront();
                }

                else
                {
                    NotesPanel.Instance.BringToFront();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(PersonalInfoPanel.Instance))
                {
                    ContentPanel.Controls.Add(PersonalInfoPanel.Instance);
                    PersonalInfoPanel.Instance.Dock = DockStyle.Fill;
                    PersonalInfoPanel.Instance.BringToFront();
                }

                else
                {
                    PersonalInfoPanel.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }


        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (PasswordsPanel.Instance.Parent.Controls.GetChildIndex(PasswordsPanel.Instance) == 0)
                    FilterDGV.FilterPasswordsDGV(PasswordsPanel.Instance.DataGridView, txtSearch);

                else if (CreditCardsPanel.Instance.Parent.Controls.GetChildIndex(CreditCardsPanel.Instance) == 0)
                    FilterDGV.FilterCreditCardsDGV(CreditCardsPanel.Instance.DataGridView, txtSearch);

                else if (PersonalInfoPanel.Instance.Parent.Controls.GetChildIndex(PersonalInfoPanel.Instance) == 0)
                    FilterDGV.FilterPersonalInfoDGV(PersonalInfoPanel.Instance.DataGridView, txtSearch);

                else if (NotesPanel.Instance.Parent.Controls.GetChildIndex(NotesPanel.Instance) == 0)
                    FilterDGV.FilterNotesDGV(NotesPanel.Instance.DataGridView, txtSearch);
            }
            catch
            {

            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(SettingsPanel.Instance))
                {
                    ContentPanel.Controls.Add(SettingsPanel.Instance);
                    SettingsPanel.Instance.Dock = DockStyle.Fill;
                    SettingsPanel.Instance.BringToFront();
                }

                else
                {
                    SettingsPanel.Instance.BringToFront();
                }

                GenerateLogs.GeneretaLog("Settings tab opened");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        private void btnLock_Click_1(object sender, EventArgs e)
        {
            GlobalVariables.RestrictClosing = true;
            GlobalVariables.DatabaseLocked = true;

            btnClose.Enabled = false;
            btnSettings.Enabled = false;
            btnLock.Enabled = false;

            btnLogOut.Enabled = false;

            txtSearch.Enabled = false;

            btnPasswords.Enabled = false;
            btnCredisCards.Enabled = false;
            PersonalInfo.Enabled = false;
            btnSecureNotes.Enabled = false;


            if (!ContentPanel.Controls.Contains(WelcomeScreen.Instance))
            {
                ContentPanel.Controls.Add(WelcomeScreen.Instance);
                WelcomeScreen.Instance.Dock = DockStyle.Fill;
                WelcomeScreen.Instance.BringToFront();
            }

            else
            {
                WelcomeScreen.Instance.BringToFront();
            }

            WelcomeScreen.Instance.Loader.Visible = true;
            WelcomeScreen.Instance.LoadingInfo.Visible = true;

            WelcomeScreen.Instance.LoadingInfo.Text = "Database is being encrypted. Wait, please...";

            bgwLock.RunWorkerAsync();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.DatabaseLocked == true)
            {
                GenerateLogs.GeneretaLog("EasyPass closed");

                Environment.Exit(0);
            }

            else if (GlobalVariables.DatabaseLocked == false)
            {
                GlobalVariables.RestrictClosing = true;
                GlobalVariables.DatabaseLocked = true;

                btnClose.Enabled = false;
                btnSettings.Enabled = false;
                btnLock.Enabled = false;
                btnLogOut.Enabled = false;

                txtSearch.Enabled = false;

                btnPasswords.Enabled = false;
                btnCredisCards.Enabled = false;
                PersonalInfo.Enabled = false;
                btnSecureNotes.Enabled = false;


                if (!ContentPanel.Controls.Contains(WelcomeScreen.Instance))
                {
                    ContentPanel.Controls.Add(WelcomeScreen.Instance);
                    WelcomeScreen.Instance.Dock = DockStyle.Fill;
                    WelcomeScreen.Instance.BringToFront();
                }

                else
                {
                    WelcomeScreen.Instance.BringToFront();
                }

                WelcomeScreen.Instance.Loader.Visible = true;
                WelcomeScreen.Instance.LoadingInfo.Visible = true;

                WelcomeScreen.Instance.LoadingInfo.Text = "Database is being encrypted. Wait, please...";


                bgwEncrypt.RunWorkerAsync();
            }

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void EasyPass_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
