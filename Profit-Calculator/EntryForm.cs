using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Profit_Calculator
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private async void EntryForm_Load(object sender, EventArgs e)
        {
            //Dictionary<string, User> users = await FirebaseOperations.GetListOfItems<User>("Users");
            string username = "e0m000200000og0o6s000";
            string password = "cccccc";
            string email = "memog0000000000o06s00oa@sd.com";

            //if (new EmailAddressAttribute().IsValid(email) && new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            //{
            //    bool isUsernameUsed = false;
            //    bool isEmailUsed = false;
            //    foreach (KeyValuePair<string, User> user in users)
            //    {
            //        if (!isUsernameUsed && Equals(user.Value.Username, username))
            //        {
            //            isUsernameUsed = true;
            //        }
            //        if (!isEmailUsed && Equals(user.Value.Email, email))
            //        {
            //            isEmailUsed = true;
            //        }
            //        if (isUsernameUsed && isEmailUsed)
            //        {
            //            break;
            //        }
            //    }

            //    if (!isUsernameUsed && !isEmailUsed)
            //    {
            //        FirebaseOperations.SetItem("Users", new User(username, email, password));
            //    }
            //    else if (isUsernameUsed && isEmailUsed)
            //    {
            //        MessageBox.Show("Ayn� kullan�c� ad� ve e-mail ile kay�tl� bir kullan�c� zaten var.");
            //    }
            //    else if (isUsernameUsed)
            //    {
            //        MessageBox.Show("Ayn� kullan�c� ad� ile kay�tl� bir kullan�c� zaten var.");
            //    }
            //    else if (isEmailUsed)
            //    {
            //        MessageBox.Show("Ayn� e-mail ile kay�tl� bir kullan�c� zaten var.");
            //    }
            //}
            //else if (!new EmailAddressAttribute().IsValid(email) && !new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            //{
            //    MessageBox.Show("�ok g�ze bat�yosun");
            //}
            //else if (!new EmailAddressAttribute().IsValid(email))
            //{
            //    MessageBox.Show("Emaili d�zg�n gir.");
            //}
            //else if (!new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            //{
            //    MessageBox.Show("Kullan�c� ad�n� d�zg�n gir.");
            //}
        }
    }
}