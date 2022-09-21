using Password_Manager.Classes;
using System;
using System.Windows.Forms;

namespace Password_Manager.Forms
{
    public partial class Registration : Form
    {
        static Registration _object;

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

        public static Registration Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new Registration();
                }
                return _object;
            }
        }
        public Registration()
        {
            InitializeComponent();

            _object = this;
            this.Icon = Properties.Resources.Icon;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Authorization.Instance.Show();

            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) ||
                !string.IsNullOrEmpty(txtAppPassword.Text) ||
                !string.IsNullOrEmpty(txtDBPassword.Text))
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.UserPassword = GetHash.HashString(txtAppPassword.Text);
                Properties.Settings.Default.DBPassword = txtDBPassword.Text;

                Properties.Settings.Default.Save();

                txtUsername.Clear();
                txtAppPassword.Clear();
                txtDBPassword.Clear();

                MessageBox.Show("Account registered successfully!",
                                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information);

                GenerateLogs.GeneretaLog("Account registered successfully!");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtAppPassword.Text) ||
                string.IsNullOrEmpty(txtDBPassword.Text))
            {
                MessageBox.Show("Fill Username, App Password and Database Password fields!", "Warning",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
        }
    }
}
