using Bunifu.UI.WinForms;
using Password_Manager.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PasswordsPanel : UserControl
    {
        private static PasswordsPanel _instance;

        public static PasswordsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PasswordsPanel();
                return _instance;
            }
        }

        public BunifuDataGridView DataGridView
        {
            get { return dgvPasswords; }
            set { dgvPasswords = value; }
        }

        public PasswordsPanel()
        {
            InitializeComponent();
        }

        private void PasswordsPanel_Load(object sender, EventArgs e)
        {
            DGVConfig();
        }

        private void DGVConfig()
        {
            FillDGV.FillPasswordsDGV(dgvPasswords);

            DataGridViewImageColumn OpenRecord = new DataGridViewImageColumn();
            dgvPasswords.Columns.Add(OpenRecord);
            OpenRecord.Image = Properties.Resources.OpenRecord;


            DataGridViewImageColumn DeleteRecord = new DataGridViewImageColumn();
            dgvPasswords.Columns.Add(DeleteRecord);
            DeleteRecord.Image = Properties.Resources.DeleteRecord;


            dgvPasswords.Columns[0].HeaderText = "ID";
            dgvPasswords.Columns[1].HeaderText = "Label";
            dgvPasswords.Columns[2].HeaderText = "Site";
            dgvPasswords.Columns[3].HeaderText = "Provider";
            dgvPasswords.Columns[4].HeaderText = "Username";
            dgvPasswords.Columns[5].HeaderText = "Password";
            dgvPasswords.Columns[6].HeaderText = "CD";
            dgvPasswords.Columns[7].HeaderText = "MD";


            dgvPasswords.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPasswords.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvPasswords.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPasswords.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPasswords.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvPasswords.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPasswords.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPasswords.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPasswords.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPasswords.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPasswords.Columns[1].Width = 200;
            dgvPasswords.Columns[4].Width = 200;
            dgvPasswords.Columns[5].Width = 200;


            dgvPasswords.Columns[0].Visible = false;
            dgvPasswords.Columns[2].Visible = false;
            dgvPasswords.Columns[3].Visible = false;
            dgvPasswords.Columns[6].Visible = false;
            dgvPasswords.Columns[7].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.DatabaseLocked == false)
            {
                GlobalVariables.PasswordReadMode = false;

                FormPassword addPassword = new FormPassword();

                addPassword.Show();
            }

            else
            {
                MessageBox.Show("Database is encrypted! Decrypt the database to add a new entry!",
                    "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if(column == 0)
            {
                if(GlobalVariables.DatabaseLocked == false)
                {
                    GlobalVariables.PasswordID = int.Parse(dgvPasswords.Rows[e.RowIndex].Cells[2].Value.ToString());
                    GlobalVariables.PasswordReadMode = true;

                    FormPassword formPassword = new FormPassword();
                    formPassword.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to get the record!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(column == 1)
            {
                if(GlobalVariables.DatabaseLocked == false)
                {
                    int Count = dgvPasswords.RowCount;

                    if (Count == 1)
                    {
                        MessageBox.Show("At least one record must be in the database!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Count > 1)
                    {
                        int Record = int.Parse(dgvPasswords.Rows[e.RowIndex].Cells[2].Value.ToString());

                        DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Record",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogResult == DialogResult.Yes)
                        {
                            DeleteRecord deleteRecord = new DeleteRecord();
                            deleteRecord.DeletePassword(Record);

                            Thread.Sleep(500);

                            FillDGV.FillPasswordsDGV(dgvPasswords);
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

        private void dgvPasswords_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2 & e.RowIndex >= 0)
            {
                DataGridViewCell dataGridcell = dgvPasswords.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var cellreactangle = dgvPasswords.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                if (dataGridcell.Value != null)
                {
                    
                    ToolTip.Show(dgvPasswords, dataGridcell.Value.ToString(), 
                        dgvPasswords.Columns[dataGridcell.ColumnIndex].HeaderText, 
                        null, dgvPasswords.PointToScreen(new Point(cellreactangle.X + 80, cellreactangle.Y)));
                }
            }
        }

        private void dgvPasswords_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ToolTip.Hide();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    FillDGV.FillPasswordsDGV(dgvPasswords);
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
