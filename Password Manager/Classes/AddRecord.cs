using JsonFlatFileDataStore;
using Password_Manager.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager
{
    public class AddRecord
    {
        public async void AddPassword(string _label, string _site, string _provider, string _username, string _password)
        {
            try
            {
                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Passwords.json";


                if (!Directory.Exists(DB_Path))
                {
                    Directory.CreateDirectory(DB_Path);
                }

                if (!File.Exists(DB_File))
                {
                    File.AppendAllText(DB_File, "{}");
                }

                var database = new DataStore(DB_File, reloadBeforeGetCollection: true);
                var collection = database.GetCollection<Passwords>();

                var newPassword = new Passwords
                {
                    Label = _label,
                    Site = _site,
                    Provider = _provider,
                    Username = _username,
                    Password = _password,
                    Created_Date = DateTime.Now,
                    Modified_Date = DateTime.Now
                };

                await collection.InsertOneAsync(newPassword);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void AddNote(string _label, string _text)
        {
            try
            {
                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\Notes.json";


                if (!Directory.Exists(DB_Path))
                {
                    Directory.CreateDirectory(DB_Path);
                }

                if (!File.Exists(DB_File))
                {
                    File.AppendAllText(DB_File, "{}");
                }

                var database = new DataStore(DB_File);
                var collection = database.GetCollection<Notes>();

                var newNote = new Notes
                {
                    Label = _label,
                    Text = _text,
                    Created_Date = DateTime.Now,
                    Modified_Date = DateTime.Now
                };

                await collection.InsertOneAsync(newNote);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void AddCreditCard(string _label, string _name, string _number, string _expDate, string _cvc_cvv, 
            string _accountNumber)
        {
            try
            {
                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\CreditCards.json";


                if (!Directory.Exists(DB_Path))
                {
                    Directory.CreateDirectory(DB_Path);
                }

                if (!File.Exists(DB_File))
                {
                    File.AppendAllText(DB_File, "{}");
                }

                var database = new DataStore(DB_File);
                var collection = database.GetCollection<CreditCards>();

                var newCreditCard = new CreditCards
                {
                    Label = _label,
                    Cardholder_Name = _name,
                    Card_Number = _number,
                    Expiration_Date = _expDate,
                    CVC_CVV = _cvc_cvv,
                    AccountNumber = _accountNumber,
                    Created_Date = DateTime.Now,
                    Modified_Date = DateTime.Now
                };

                await collection.InsertOneAsync(newCreditCard);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }

        public async void AddPersonalInfo(string _label, string _firstName, string _lastName, string _organization = null,
                                          string _organizationTitle = null, string _phoneW = null, string _phoneP = null, 
                                          string _email = null, string _website = null, string _country = null, 
                                          string _city = null, string _street = null, string _zipcode = null, 
                                          string _notes = null)
        {
            try
            {
                var DB_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database";
                var DB_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\EasyPass\Database\PersonalInfo.json";


                if (!Directory.Exists(DB_Path))
                {
                    Directory.CreateDirectory(DB_Path);
                }

                if (!File.Exists(DB_File))
                {
                    File.AppendAllText(DB_File, "{}");
                }


                var database = new DataStore(DB_File);
                var collection = database.GetCollection<PersonalInfo>();

                var newPersonalInfo = new PersonalInfo
                {
                    Label = _label,
                    First_Name = _firstName,
                    Last_Name = _lastName,
                    Organization = _organization,
                    Organization_Title = _organizationTitle,
                    PhoneWork = _phoneW,
                    PhonePrivate = _phoneP,
                    Email = _email,
                    Website = _website,
                    Country = _country,
                    City = _city,
                    Street = _street,
                    Zipcode = _zipcode,
                    Notes = _notes,
                    Created_Date = DateTime.Now,
                    Modified_Date = DateTime.Now
                };

                await collection.InsertOneAsync(newPersonalInfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GenerateLogs.GeneretaLog(ex.Message);
            }
        }
    }
}
