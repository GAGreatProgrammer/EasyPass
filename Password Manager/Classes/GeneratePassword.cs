using System;

namespace Password_Manager.Classes
{
    public static class GeneratePassword
    {
        public static string RandomPassword(int length)
        {
            const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string Numbers = "1234567890";
            const string Symbols = @"~!@#$%^&*():;[]{}<>,.?/\|";

            try
            {
                char[] password = new char[length];
                string charSet = "";


                Random random = new Random();

                charSet += Uppercase;

                charSet += Lowercase;

                charSet += Numbers;

                charSet += Symbols;

                for (int i = 0; i < length; i++)
                    password[i] = charSet[random.Next(charSet.Length - 1)];

                return string.Join(null, password);
            }
            catch
            {
                return "Something went wrong!";
            }
        }
    }
}
