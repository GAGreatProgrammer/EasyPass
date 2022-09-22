# **EasyPass** 
---
![Developed_by](https://img.shields.io/badge/Developed_by-GAGreatProgrammer-green) ![OS](https://img.shields.io/badge/OS-_Windows-blue) ![.Net](https://img.shields.io/badge/.Net-_v4.7.2-red) ![GitHub last commit](https://img.shields.io/github/last-commit/GAGreatProgrammer/EasyPass) ![GitHub](https://img.shields.io/github/license/GAGreatProgrammer/EasyPass?color=orange)
<br/>

Easy Pass is a password manager that provides a secure container feature that stores all confidential information. EasyPass can store passwords, credit cards, user's personal information and notes. All data is stored in JSON format. To ensure the highest level of personal data protection, EasyPass uses an advanced level of AES encryption.

<br/>

## Application Features
---
![EasyPass](https://raw.githubusercontent.com/GAGreatProgrammer/EasyPass/master/Password%20Manager/Assets/EasyPass.PNG)

EasyPass allows the user to store confidential information in a secure container that is encrypted with the AES encryption algorithm. This provides a high level of information security. Using the EasyPass program, the user can be sure that only he can view the stored information. Program can store the following information:

* Website passwords. It is possible to select the desired browser.

* Credit card details. User can select credit card number and bank account.

* User's personal data. This data includes first name, last name, phone number, email address, etc.

* Notes. This feature allows you to store a large amount of text data in a convenient format.

The program is accessed using a `Username` and `Password`. However, the database files are encrypted with a separate password that the user creates.

<br/>

## Registration
---

The first time you open EasyPass, you will need to create a new account. To do this, click the `Register here` button on the authorization form. Then enter the username, application password, and database password. This completes the registration. If you want to reset your account, enter the username and application password on the authorization form and click the `Reset account` button. `BE CAREFUL`, after resetting the account, all user data will be deleted, including records in the database.

<n/>

Also, after registration, you can change the username, application password and database password from the settings tab. This tab also contains information with program logs that are created automatically. All files including database and log files are stored in `C:\Program Files (x86)\EasyPass`.

![EasyPass](https://raw.githubusercontent.com/GAGreatProgrammer/EasyPass/master/Password%20Manager/Assets/Settings.PNG)

If desired, the user can reset the settings by clicking the "Default" button on the settings tab. In this case, the username, application password and database password will be: `EasyPass`. It is important that when resetting to factory settings, the information is not deleted from the database.

<br/>

## Adding new record
---
To add a new record, user should click on the `Add new` button in the corresponding tab. After that, a form will open in which the user must enter the required data.

![EasyPass](https://raw.githubusercontent.com/GAGreatProgrammer/EasyPass/master/Password%20Manager/Assets/Passwords.PNG)

This photo shows the `Passwords` tab. To view the saved password, you must click on the green button in the right corner of the record. To delete, you must press the button with the image of a trash can. Based on the specifics of the application, at least one record must remain in the database. When a database is created, a test record is written to it. You can leave this entry if you wish to delete all entries. 

## Encrypting and Decrypting data
---
The `AES` encryption algorithm is used to encrypt files and the `3DES` encryption algorithm is used to encrypt text data. To ensure security, user data (username, application password and database password) is stored in encrypted form.

#### Encrypting files

```csharp
public static void FileEncrypt(string inputFile, string password)
        {
            byte[] salt = Salt.GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7
            };

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);


            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                fsIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                GenerateLogs.GeneretaLog("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
```
#### Encrypting text data

```csharp

        public static string TextEncrypt(string text, string key)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            tripleDESCryptoService.Key = byteHash;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            byte[] data = Encoding.Unicode.GetBytes(text);
            return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
        }
```
<br/>

#### Decrypting files
```csharp
public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message);

                GenerateLogs.GeneretaLog("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                GenerateLogs.GeneretaLog("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message);

                GenerateLogs.GeneretaLog("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
```

#### Decrypting text data
```csharp
public static string TextDecrypt(string text, string key)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            tripleDESCryptoService.Key = byteHash;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            byte[] byteBuff = Convert.FromBase64String(text);
            return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
        }
```

<br/>

## Working with database
---
The database file represents the JSON file in which records are stored. After the EasyPass program is closed, the JSON file is encrypted. It is possible to decrypt it only in the EasyPass program. If you want to decrypt the file yourself, you can [use this program.](https://github.com/GAGreatProgrammer/SecureFile)

#### Adding Password record in JSON file

```csharp
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
```
<br/>

## Additional information

In the EasyPass password manager, the user can urgently block the program by pressing the `Lock` button on the main form. This will encrypt the database and user data. After that, to access the data, you will need to re-authorize in the program.

Given the fact that the user's records are not stored in the cloud, but are encrypted on the user's device, it is extremely difficult to gain unauthorized access to them. This allows you to protect confidential data and provide a high level of user security. If necessary, the user can urgently reset the account, which will lead to the complete destruction of data.

The EasyPass password manager is extremely secure for storing personal information when the user needs to be sure that his data is safe and secure.

