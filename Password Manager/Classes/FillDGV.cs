using Bunifu.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Classes
{
    public class FillDGV
    {
        public static void FillPasswordsDGV(BunifuDataGridView DataGridView)
        {
            try
            {
                var Password_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";
                string passwordsData = File.ReadAllText(Password_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(passwordsData);

                DataGridView.DataSource = dataSet.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FillNotesDGV(BunifuDataGridView DataGridView)
        {
            try
            {
                var Notes_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";
                string notesData = File.ReadAllText(Notes_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(notesData);

                DataGridView.DataSource = dataSet.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FillCreditCardsDGV(BunifuDataGridView DataGridView)
        {
            try
            {
                var CreditCards_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";
                string CreditCardsData = File.ReadAllText(CreditCards_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(CreditCardsData);

                DataGridView.DataSource = dataSet.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }

        public static void FillPersonalInfoDGV(BunifuDataGridView DataGridView)
        {
            try
            {
                var PersonalInfo_DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";
                string PersonalInfoData = File.ReadAllText(PersonalInfo_DB_Path);

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(PersonalInfoData);

                DataGridView.DataSource = dataSet.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
            
        }
    }
}
