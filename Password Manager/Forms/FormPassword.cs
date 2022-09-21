using Bunifu.UI.WinForms;
using JsonFlatFileDataStore;
using Password_Manager.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FormPassword : Form
    {
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

        public FormPassword()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon;
        }

        private void AddPassword_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.PasswordReadMode == true)
            {
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;


                var store = new DataStore($@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json");

                var collection = store.GetCollection<Passwords>();


                var Data = collection
                                    .AsQueryable()
                                    .FirstOrDefault(p => p.ID == GlobalVariables.PasswordID);

                txtLabel.Text = Data.Label;
                txtSite.Text = Data.Site;
                cboProvider.Text = Data.Provider;
                txtUsername.Text = Data.Site;
                txtPassword.Text = Data.Password;

            }
            else if (GlobalVariables.PasswordReadMode == false)
            {
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLabel.Text == "" || txtSite.Text == "" || cboProvider.SelectedItem == null || 
                txtUsername.Text == "" || txtPassword.Text == "")
            {
                Snackbar.Show(this, "Fill all fields!", BunifuSnackbar.MessageTypes.Warning,
                duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
                return;
            }

            else
            {
                AddRecord addRecord = new AddRecord();
                addRecord.AddPassword(txtLabel.Text, txtSite.Text, cboProvider.Text, txtUsername.Text, txtPassword.Text);
                ClearData();

                Snackbar.Show(this, "Password saved!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
        }

        private void ClearData()
        {
            txtLabel.Clear();
            txtSite.Clear();
            cboProvider.SelectedItem = null;
            cboProvider.Text = "Provider";
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
