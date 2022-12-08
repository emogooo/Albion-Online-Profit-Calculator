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
            //        MessageBox.Show("Ayný kullanýcý adý ve e-mail ile kayýtlý bir kullanýcý zaten var.");
            //    }
            //    else if (isUsernameUsed)
            //    {
            //        MessageBox.Show("Ayný kullanýcý adý ile kayýtlý bir kullanýcý zaten var.");
            //    }
            //    else if (isEmailUsed)
            //    {
            //        MessageBox.Show("Ayný e-mail ile kayýtlý bir kullanýcý zaten var.");
            //    }
            //}
            //else if (!new EmailAddressAttribute().IsValid(email) && !new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            //{
            //    MessageBox.Show("Çok göze batýyosun");
            //}
            //else if (!new EmailAddressAttribute().IsValid(email))
            //{
            //    MessageBox.Show("Emaili düzgün gir.");
            //}
            //else if (!new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            //{
            //    MessageBox.Show("Kullanýcý adýný düzgün gir.");
            //}
        }
    }
}