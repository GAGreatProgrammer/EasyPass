using JsonFlatFileDataStore;
using System;
using System.Windows.Forms;

namespace Password_Manager.Classes
{
    public class DeleteRecord
    {
        public async void DeletePassword(int _id)
        {
            try
            {
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";

                var database = new DataStore(DB_File, reloadBeforeGetCollection: true);
                var collection = database.GetCollection<Passwords>();

                await collection.DeleteOneAsync(_id);
                database.Reload();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void DeleteNote(int _id)
        {
            try
            {
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";


                var database = new DataStore(DB_File, reloadBeforeGetCollection: true);
                var collection = database.GetCollection<Notes>();

                await collection.DeleteOneAsync(_id);
                database.Reload();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void DeleteCreditCard(int _id)
        {
            try
            {
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";

                var database = new DataStore(DB_File, reloadBeforeGetCollection: true);
                var collection = database.GetCollection<CreditCards>();

                await collection.DeleteOneAsync(_id);
                database.Reload();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void DeletePersonalInfo(int _id)
        {
            try
            {
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";

                var database = new DataStore(DB_File, reloadBeforeGetCollection: true);
                var collection = database.GetCollection<PersonalInfo>();

                await collection.DeleteOneAsync(_id);
                database.Reload();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }
    }
}
