using Bunifu.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Classes
{
    public class FilterDGV
    {
        public static void FilterPasswordsDGV(BunifuDataGridView DataGridView, BunifuTextBox Search)
        {
            try
            {
                var Password_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";
                string passwordsData = File.ReadAllText(Password_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(passwordsData);

                DataView dataView = dataSet.Tables[0].DefaultView;

                if (!string.IsNullOrEmpty(Search.Text))
                {
                    dataView.RowFilter = $"Label LIKE '{Search.Text}'";

                    DataGridView.DataSource = dataView;
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FilterNotesDGV(BunifuDataGridView DataGridView, BunifuTextBox Search)
        {
            try
            {
                var Notes_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";
                string notesData = File.ReadAllText(Notes_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(notesData);

                DataView dataView = dataSet.Tables[0].DefaultView;

                if (!string.IsNullOrEmpty(Search.Text))
                {
                    dataView.RowFilter = $"Label LIKE '{Search.Text}'";

                    DataGridView.DataSource = dataView;
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FilterCreditCardsDGV(BunifuDataGridView DataGridView, BunifuTextBox Search)
        {
            try
            {
                var CreditCards_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";
                string CreditCardsData = File.ReadAllText(CreditCards_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(CreditCardsData);

                DataView dataView = dataSet.Tables[0].DefaultView;

                if (!string.IsNullOrEmpty(Search.Text))
                {
                    dataView.RowFilter = $"Label LIKE '{Search.Text}'";

                    DataGridView.DataSource = dataView;
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FilterPersonalInfoDGV(BunifuDataGridView DataGridView, BunifuTextBox Search)
        {
            try
            {
                var PersonalInfo_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";
                string PersonalInfoData = File.ReadAllText(PersonalInfo_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(PersonalInfoData);

                DataView dataView = dataSet.Tables[0].DefaultView;

                if (!string.IsNullOrEmpty(Search.Text))
                {
                    dataView.RowFilter = $"Label LIKE '{Search.Text}'";

                    DataGridView.DataSource = dataView;
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }
    }
}
