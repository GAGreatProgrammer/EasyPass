using Bunifu.UI.WinForms;
using Password_Manager.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class NotesPanel : UserControl
    {
        private static NotesPanel _instance;

        public static NotesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NotesPanel();
                return _instance;
            }
        }

        public BunifuDataGridView DataGridView
        {
            get { return dgvNotes; }
            set { dgvNotes = value; }
        }
        public NotesPanel()
        {
            InitializeComponent();
        }

        private void NotesPanel_Load(object sender, EventArgs e)
        {
            DGVConfig();
        }

        private void DGVConfig()
        {
            FillDGV.FillNotesDGV(dgvNotes);

            DataGridViewImageColumn OpenRecord = new DataGridViewImageColumn();
            dgvNotes.Columns.Add(OpenRecord);
            OpenRecord.Image = Properties.Resources.OpenRecord;


            DataGridViewImageColumn DeleteRecord = new DataGridViewImageColumn();
            dgvNotes.Columns.Add(DeleteRecord);
            DeleteRecord.Image = Properties.Resources.DeleteRecord;


            dgvNotes.Columns[0].HeaderText = "ID";
            dgvNotes.Columns[1].HeaderText = "Label";
            dgvNotes.Columns[2].HeaderText = "Note";
            dgvNotes.Columns[3].HeaderText = "CD";
            dgvNotes.Columns[4].HeaderText = "MD";


            dgvNotes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotes.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotes.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvNotes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvNotes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNotes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNotes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNotes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvNotes.Columns[1].Width = 200;
            dgvNotes.Columns[2].Width = 400;


            dgvNotes.Columns[0].Visible = false;
            dgvNotes.Columns[3].Visible = false;
            dgvNotes.Columns[4].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.DatabaseLocked == false)
            {
                GlobalVariables.NoteReadMode = false;

                FormNote addNote = new FormNote();

                addNote.Show();
            }

            else
            {
                MessageBox.Show("Database is encrypted! Decrypt the database to add a new entry!",
                    "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNotes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2 & e.RowIndex >= 0)
            {
                DataGridViewCell dataGridcell = dgvNotes.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var cellreactangle = dgvNotes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                if (dataGridcell.Value != null)
                {

                    ToolTip.Show(dgvNotes, dataGridcell.Value.ToString(),
                         dgvNotes.Columns[dataGridcell.ColumnIndex].HeaderText,
                        null, dgvNotes.PointToScreen(new Point(cellreactangle.X + 80, cellreactangle.Y)));
                }
            }
        }

        private void dgvNotes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ToolTip.Hide();
        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if (column == 0)
            {
                if(GlobalVariables.DatabaseLocked == false)
                {
                    GlobalVariables.NoteID = int.Parse(dgvNotes.Rows[e.RowIndex].Cells[2].Value.ToString());
                    GlobalVariables.NoteReadMode = true;

                    FormNote formNote = new FormNote();
                    formNote.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Database is encrypted! Decrypt the database to get the record!",
                        "Database Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (column == 1)
            {
                if(GlobalVariables.DatabaseLocked == false)
                {
                    int Count = dgvNotes.RowCount;

                    if (Count == 1)
                    {
                        MessageBox.Show("At least one record must be in the database!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Count > 1)
                    {
                        int Record = int.Parse(dgvNotes.Rows[e.RowIndex].Cells[2].Value.ToString());

                        DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Record",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogResult == DialogResult.Yes)
                        {
                            DeleteRecord deleteRecord = new DeleteRecord();
                            deleteRecord.DeleteNote(Record);

                            Thread.Sleep(500);

                            FillDGV.FillNotesDGV(dgvNotes);
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DatabaseLocked == false)
                {
                    FillDGV.FillNotesDGV(dgvNotes);
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
