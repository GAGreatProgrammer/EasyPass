using Bunifu.UI.WinForms;
using Password_Manager.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class CreditCardsPanel : UserControl
    {
        private static CreditCardsPanel _instance;

        public static CreditCardsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CreditCardsPanel();
                return _instance;
            }
        }

        public BunifuDataGridView DataGridView
        {
            get { return dgvCreditCard; }
            set { dgvCreditCard = value; }
        }
        public CreditCardsPanel()
        {
            InitializeComponent();
        }

        private void CreditCardPanel_Load(object sender, EventArgs e)
        {
            DGVConfig();
        }

        private void DGVConfig()
        {
            FillDGV.FillCreditCardsDGV(dgvCreditCard);

            DataGridViewImageColumn OpenRecord = new DataGridViewImageColumn();
            dgvCreditCard.Columns.Add(OpenRecord);
            OpenRecord.Image = Properties.Resources.OpenRecord;


            DataGridViewImageColumn DeleteRecord = new DataGridViewImageColumn();
            dgvCreditCard.Columns.Add(DeleteRecord);
            DeleteRecord.Image = Properties.Resources.DeleteRecord;


            dgvCreditCard.Columns[0].HeaderText = "ID";
            dgvCreditCard.Columns[1].HeaderText = "Label";
            dgvCreditCard.Columns[2].HeaderText = "Name";
            dgvCreditCard.Columns[3].HeaderText = "Number";
            dgvCreditCard.Columns[4].HeaderText = "Exp. Date";
            dgvCreditCard.Columns[5].HeaderText = "CVC/CVV";
            dgvCreditCard.Columns[6].HeaderText = "Account Number";
            dgvCreditCard.Columns[7].HeaderText = "CD";
            dgvCreditCard.Columns[8].HeaderText = "MD";


            dgvCreditCard.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCreditCard.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvCreditCard.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCreditCard.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCreditCard.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvCreditCard.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCreditCard.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCreditCard.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCreditCard.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCreditCard.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvCreditCard.Columns[1].Width = 200;
            dgvCreditCard.Columns[2].Width = 200;
            dgvCreditCard.Columns[3].Width = 200;


            dgvCreditCard.Columns[0].Visible = false;
            dgvCreditCard.Columns[4].Visible = false;
            dgvCreditCard.Columns[5].Visible = false;
            dgvCreditCard.Columns[6].Visible = false;
            dgvCreditCard.Columns[7].Visible = false;
            dgvCreditCard.Columns[8].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    GlobalVariables.CreditCardReadMode = false;

                    FormCreditCard addCreditCard = new FormCreditCard();

                    addCreditCard.Show();
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to add a new entry!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {

            }
        }

        private void dgvCreditCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if (column == 0)
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    GlobalVariables.CreditCardID = int.Parse(dgvCreditCard.Rows[e.RowIndex].Cells[2].Value.ToString());
                    GlobalVariables.CreditCardReadMode = true;

                    FormCreditCard formCreditCard = new FormCreditCard();
                    formCreditCard.ShowDialog();
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
                    int Count = dgvCreditCard.RowCount;

                    if (Count == 1)
                    {
                        MessageBox.Show("At least one record must be in the database!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Count > 1)
                    {
                        int Record = int.Parse(dgvCreditCard.Rows[e.RowIndex].Cells[2].Value.ToString());

                        DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Record",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogResult == DialogResult.Yes)
                        {
                            DeleteRecord deleteRecord = new DeleteRecord();
                            deleteRecord.DeleteCreditCard(Record);

                            Thread.Sleep(500);

                            FillDGV.FillCreditCardsDGV(dgvCreditCard);
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

        private void dgvCreditCard_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2 & e.RowIndex >= 0)
            {
                DataGridViewCell dataGridcell = dgvCreditCard.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var cellreactangle = dgvCreditCard.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                if (dataGridcell.Value != null)
                {

                    ToolTip.Show(dgvCreditCard, dataGridcell.Value.ToString(),
                        dgvCreditCard.Columns[dataGridcell.ColumnIndex].HeaderText,
                        null, dgvCreditCard.PointToScreen(new Point(cellreactangle.X + 80, cellreactangle.Y)));
                }
            }
        }

        private void dgvCreditCard_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ToolTip.Hide();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    FillDGV.FillCreditCardsDGV(dgvCreditCard);
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
