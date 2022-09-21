using Bunifu.UI.WinForms;
using Password_Manager.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class PersonalInfoPanel : UserControl
    {
        private static PersonalInfoPanel _instance;

        public static PersonalInfoPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PersonalInfoPanel();
                return _instance;
            }
        }

        public BunifuDataGridView DataGridView
        {
            get { return dgvPersonalInfo; }
            set { dgvPersonalInfo = value; }
        }

        public PersonalInfoPanel()
        {
            InitializeComponent();
        }

        private void PersonalInfoPanel_Load(object sender, EventArgs e)
        {
            DGVConfig();
        }

        private void DGVConfig()
        {
            FillDGV.FillPersonalInfoDGV(dgvPersonalInfo);


            DataGridViewImageColumn OpenRecord = new DataGridViewImageColumn();
            dgvPersonalInfo.Columns.Add(OpenRecord);
            OpenRecord.Image = Properties.Resources.OpenRecord;


            DataGridViewImageColumn DeleteRecord = new DataGridViewImageColumn();
            dgvPersonalInfo.Columns.Add(DeleteRecord);
            DeleteRecord.Image = Properties.Resources.DeleteRecord;


            dgvPersonalInfo.Columns[0].HeaderText = "ID";
            dgvPersonalInfo.Columns[1].HeaderText = "Label";
            dgvPersonalInfo.Columns[2].HeaderText = "First Name";
            dgvPersonalInfo.Columns[3].HeaderText = "Last Name";
            dgvPersonalInfo.Columns[4].HeaderText = "Organization";
            dgvPersonalInfo.Columns[5].HeaderText = "Organization Title";
            dgvPersonalInfo.Columns[6].HeaderText = "Phone (Work)";
            dgvPersonalInfo.Columns[7].HeaderText = "Phone (Private)";
            dgvPersonalInfo.Columns[8].HeaderText = "Email";
            dgvPersonalInfo.Columns[9].HeaderText = "Website ";
            dgvPersonalInfo.Columns[10].HeaderText = "Country";
            dgvPersonalInfo.Columns[11].HeaderText = "City";
            dgvPersonalInfo.Columns[12].HeaderText = "Street";
            dgvPersonalInfo.Columns[13].HeaderText = "Zipcode";
            dgvPersonalInfo.Columns[14].HeaderText = "Notes";
            dgvPersonalInfo.Columns[15].HeaderText = "CD";
            dgvPersonalInfo.Columns[16].HeaderText = "MD";


            dgvPersonalInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonalInfo.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvPersonalInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonalInfo.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonalInfo.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvPersonalInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPersonalInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPersonalInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPersonalInfo.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPersonalInfo.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvPersonalInfo.Columns[1].Width = 200;
            dgvPersonalInfo.Columns[2].Width = 200;
            dgvPersonalInfo.Columns[3].Width = 200;


            dgvPersonalInfo.Columns[0].Visible = false;
            dgvPersonalInfo.Columns[4].Visible = false;
            dgvPersonalInfo.Columns[5].Visible = false;
            dgvPersonalInfo.Columns[6].Visible = false;
            dgvPersonalInfo.Columns[7].Visible = false;
            dgvPersonalInfo.Columns[8].Visible = false;
            dgvPersonalInfo.Columns[9].Visible = false;
            dgvPersonalInfo.Columns[10].Visible = false;
            dgvPersonalInfo.Columns[11].Visible = false;
            dgvPersonalInfo.Columns[12].Visible = false;
            dgvPersonalInfo.Columns[13].Visible = false;
            dgvPersonalInfo.Columns[14].Visible = false;
            dgvPersonalInfo.Columns[15].Visible = false;
            dgvPersonalInfo.Columns[16].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.DatabaseLocked == false)
            {
                GlobalVariables.PersonalInfoReadMode = false;

                FormPersonalInfo addPersonalInfo = new FormPersonalInfo();

                addPersonalInfo.Show();
            }

            else
            {
                MessageBox.Show("Database is encrypted! Decrypt the database to add a new entry!",
                    "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void dgvPersonalInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if (column == 0)
            {
                if(GlobalVariables.DatabaseLocked == false)
                {
                    GlobalVariables.PersonalInfoID = int.Parse(dgvPersonalInfo.Rows[e.RowIndex].Cells[2].Value.ToString());
                    GlobalVariables.PersonalInfoReadMode = true;

                    FormPersonalInfo formPersonalInfo = new FormPersonalInfo();
                    formPersonalInfo.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to get the record!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (column == 1)
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    int Count = dgvPersonalInfo.RowCount;

                    if (Count == 1)
                    {
                        MessageBox.Show("At least one record must be in the database!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Count > 1)
                    {
                        int Record = int.Parse(dgvPersonalInfo.Rows[e.RowIndex].Cells[2].Value.ToString());

                        DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Record",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogResult == DialogResult.Yes)
                        {
                            DeleteRecord deleteRecord = new DeleteRecord();
                            deleteRecord.DeletePersonalInfo(Record);

                            Thread.Sleep(500);

                            FillDGV.FillPersonalInfoDGV(dgvPersonalInfo);
                        }

                        else if (dialogResult == DialogResult.No)
                            return;
                    }
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to delete the entry!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvPersonalInfo_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2 & e.RowIndex >= 0)
            {
                DataGridViewCell dataGridcell = dgvPersonalInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var cellreactangle = dgvPersonalInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                if (dataGridcell.Value != null)
                {

                    ToolTip.Show(dgvPersonalInfo, dataGridcell.Value.ToString(),
                         dgvPersonalInfo.Columns[dataGridcell.ColumnIndex].HeaderText,
                        null, dgvPersonalInfo.PointToScreen(new Point(cellreactangle.X + 80, cellreactangle.Y)));
                }
            }
        }

        private void dgvPersonalInfo_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ToolTip.Hide();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    FillDGV.FillPersonalInfoDGV(dgvPersonalInfo);
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to reload the list!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                
            }
        }
    }
}
