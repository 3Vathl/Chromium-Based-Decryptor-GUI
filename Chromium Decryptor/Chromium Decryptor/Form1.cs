using Chromium_Decryptor.Modules;
using Chromium_Decryptor.Modules.Classes;

namespace Chromium_Decryptor
{
    public partial class Decryptor : Form
    {

        public Decryptor()
        {
            InitializeComponent();
        }

        private void Gx_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Vathl_\\AppData\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Utility.OperaGx = openFileDialog.SelectedPath;
                }
            }

            OperaGx.CreditCards(Utility.OperaGx);
            OperaGx.Passwords(Utility.OperaGx);
            OperaGx.History(Utility.OperaGx);
            OperaGx.AutoFill(Utility.OperaGx);
            OperaGx.Bookmarks(Utility.OperaGx);
            OperaGx.Cookies(Utility.OperaGx);

            label5.Text = "" + Total.CCS + " CC`S Extracted";
            label3.Text = "" + Total.BOOKMARKS + " Bookmarks Extracted";
            label2.Text = "" + Total.PASSWORDS + " Passwords Extracted";
            label1.Text = "" + Total.COOKIES + " Cookies Extracted";
            label4.Text = "" + Total.HISTORY + " History Extracted";
            label6.Text = "" + Total.AUTOFILLS + " AutoFills Extracted";
        }

        private void Edge_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Vathl_\\AppData\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Utility.Microsoft = openFileDialog.SelectedPath;
                }
            }
            OperaGx.CreditCards(Utility.OperaGx);
            OperaGx.Passwords(Utility.OperaGx);
            OperaGx.History(Utility.OperaGx);
            OperaGx.AutoFill(Utility.OperaGx);
            OperaGx.Bookmarks(Utility.OperaGx);
            OperaGx.Cookies(Utility.OperaGx);

            label5.Text = "" + Total.CCS + " CC`S Extracted";
            label3.Text = "" + Total.BOOKMARKS + " Bookmarks Extracted";
            label2.Text = "" + Total.PASSWORDS + " Passwords Extracted";
            label1.Text = "" + Total.COOKIES + " Cookies Extracted";
            label4.Text = "" + Total.HISTORY + " History Extracted";
            label6.Text = "" + Total.AUTOFILLS + " AutoFills Extracted";
        }
        private void Opera_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Vathl_\\AppData\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Utility.Opera = openFileDialog.SelectedPath;
                }
            }
            OperaQ.CreditCards(Utility.OperaGx);
            OperaQ.Passwords(Utility.OperaGx);
            OperaQ.History(Utility.OperaGx);
            OperaQ.AutoFill(Utility.OperaGx);
            OperaQ.Bookmarks(Utility.OperaGx);
            OperaQ.Cookies(Utility.OperaGx);

            label5.Text = "" + Total.CCS + " CC`S Extracted";
            label3.Text = "" + Total.BOOKMARKS + " Bookmarks Extracted";
            label2.Text = "" + Total.PASSWORDS + " Passwords Extracted";
            label1.Text = "" + Total.COOKIES + " Cookies Extracted";
            label4.Text = "" + Total.HISTORY + " History Extracted";
            label6.Text = "" + Total.AUTOFILLS + " AutoFills Extracted";
        }
        private void Chrome_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Vathl_\\AppData\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Utility.Chrome = openFileDialog.SelectedPath;
                }
            }
            ChromeQ.CreditCards(Utility.OperaGx);
            ChromeQ.Passwords(Utility.OperaGx);
            ChromeQ.History(Utility.OperaGx);
            ChromeQ.AutoFill(Utility.OperaGx);
            ChromeQ.Bookmarks(Utility.OperaGx);
            ChromeQ.Cookies(Utility.OperaGx);

            label5.Text = "" + Total.CCS + " CC`S Extracted";
            label3.Text = "" + Total.BOOKMARKS + " Bookmarks Extracted";
            label2.Text = "" + Total.PASSWORDS + " Passwords Extracted";
            label1.Text = "" + Total.COOKIES + " Cookies Extracted";
            label4.Text = "" + Total.HISTORY + " History Extracted";
            label6.Text = "" + Total.AUTOFILLS + " AutoFills Extracted";
        }
    }
}
