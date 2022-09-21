using Bunifu.UI.WinForms;
using JsonFlatFileDataStore;
using Password_Manager.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FormPersonalInfo : Form
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

        public FormPersonalInfo()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon;
        }

        private void AddPersonalInfo_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.PersonalInfoReadMode == true)
            {
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;


                var store = new DataStore($@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json");

                var collection = store.GetCollection<PersonalInfo>();


                var Data = collection
                                    .AsQueryable()
                                    .FirstOrDefault(p => p.ID == GlobalVariables.PersonalInfoID);

                txtLabel.Text = Data.Label;
                txtFirstName.Text = Data.First_Name;
                txtLastName.Text = Data.Last_Name;
                txtOrganization.Text = Data.Organization;
                txtOrganizationTitle.Text = Data.Organization_Title;
                txtPhoneW.Text = Data.PhoneWork;
                txtPhoneP.Text = Data.PhonePrivate;
                txtEmail.Text = Data.Email;
                txtWebsite.Text = Data.Website;
                txtCountry.Text = Data.Country;
                txtCity.Text = Data.City;
                txtStreet.Text = Data.Street;
                txtZipcode.Text = Data.Zipcode;
                txtNotes.Text = Data.Notes;

            }
            else if (GlobalVariables.PersonalInfoReadMode == false)
            {
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
        }

        private void ClearData()
        {
            txtLabel.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtOrganization.Clear();
            txtOrganizationTitle.Clear();
            txtPhoneW.Clear();
            txtPhoneP.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtStreet.Clear();
            txtZipcode.Clear();
            txtNotes.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtLabel.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                Snackbar.Show(this, "Fill Label, First Name and Last Name fields!", BunifuSnackbar.MessageTypes.Warning,
                duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
                return;
            }
            else
            {
                AddRecord addRecord = new AddRecord();
                addRecord.AddPersonalInfo(txtLabel.Text, txtFirstName.Text, txtLastName.Text, txtOrganization.Text, txtOrganizationTitle.Text,
                    txtPhoneW.Text, txtPhoneP.Text, txtEmail.Text, txtWebsite.Text, txtCountry.Text, txtCity.Text, txtStreet.Text,
                    txtZipcode.Text, txtNotes.Text);
                ClearData();

                Snackbar.Show(this, "Personal Information saved!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
