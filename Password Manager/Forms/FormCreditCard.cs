using Bunifu.UI.WinForms;
using JsonFlatFileDataStore;
using Password_Manager.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FormCreditCard : Form
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

        public FormCreditCard()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon;
        }

        private void AddCreditCard_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.CreditCardReadMode == true)
            {
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;


                var store = new DataStore($@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json");

                var collection = store.GetCollection<CreditCards>();


                var Data = collection
                                    .AsQueryable()
                                    .FirstOrDefault(p => p.ID == GlobalVariables.CreditCardID);


                txtLabel.Text = Data.Label;
                txtName.Text = Data.Cardholder_Name;
                txtCardNumber.Text = Data.Card_Number;
                txtExpDate.Text = Data.Expiration_Date;
                txtCVC_CVV.Text = Data.CVC_CVV;
                txtAccountNumber.Text = Data.AccountNumber;

            }
            else if (GlobalVariables.CreditCardReadMode == false)
            {
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
        }

        private void ClearData()
        {
            txtLabel.Clear();
            txtName.Clear();
            txtCardNumber.Clear();
            txtExpDate.Clear();
            txtCVC_CVV.Clear();
            txtAccountNumber.Clear();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtLabel.Text == "" || txtName.Text == "" || txtCardNumber.Text == "" || 
                txtExpDate.Text == "" || txtCVC_CVV.Text == "" || txtAccountNumber.Text == "")
            {

                Snackbar.Show(this, "Fill all fields!", BunifuSnackbar.MessageTypes.Warning,
                duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
                return;
            }
            else
            {
                AddRecord addRecord = new AddRecord();
                addRecord.AddCreditCard(txtLabel.Text, txtName.Text, txtCardNumber.Text, txtExpDate.Text, txtCVC_CVV.Text, txtAccountNumber.Text);
                ClearData();

                Snackbar.Show(this, "Credit card saved!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
