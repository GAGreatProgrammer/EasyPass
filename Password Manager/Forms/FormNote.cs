using Bunifu.UI.WinForms;
using JsonFlatFileDataStore;
using Password_Manager.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class FormNote : Form
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

        public FormNote()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon;  
        }



        private void FormNote_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.NoteReadMode == true)
            {
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;


                var store = new DataStore($@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json");

                var collection = store.GetCollection<Notes>();


                var Data = collection
                                    .AsQueryable()
                                    .FirstOrDefault(p => p.ID == GlobalVariables.NoteID);

                txtLabel.Text = Data.Label;
                txtText.Text = Data.Text;

            }
            else if (GlobalVariables.NoteReadMode == false)
            {
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
        }

        private void ClearData()
        {
            txtLabel.Clear();
            txtText.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtLabel.Text == "" || txtText.Text == "")
            {
                Snackbar.Show(this, "Fill all fields!", BunifuSnackbar.MessageTypes.Warning,
                duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
                return;
            }
            else
            {
                AddRecord addRecord = new AddRecord();
                addRecord.AddNote(txtLabel.Text, txtText.Text);
                ClearData();

                Snackbar.Show(this, "Note saved!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
