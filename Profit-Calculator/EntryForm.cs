using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Profit_Calculator
{
    public partial class EntryForm : Form
    {
        private bool mouseDown;
        private Point offSet;
        public EntryForm()
        {
            InitializeComponent();
            panelRegister.Hide();
            Opacity = 0.9;
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
        private void EntryForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void EntryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offSet.X, currentScreenPos.Y - offSet.Y);
            }
        }
        private void EntryForm_MouseDown(object sender, MouseEventArgs e)
        {
            offSet.X = e.X;
            offSet.Y = e.Y;
            mouseDown = true;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonGoBackToLogin_Click(object sender, EventArgs e)
        {
            panelRegister.Hide();
        }
        private void buttonGoToRegisterForm_Click(object sender, EventArgs e)
        {
            panelRegister.Show();
        }
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxRegisterUsername.Text;
            string password = textBoxRegisterPassword.Text;
            string email = textBoxRegisterEmail.Text;

            if (new EmailAddressAttribute().IsValid(email) && new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            {
                bool isUsernameUsed = false;
                bool isEmailUsed = false;
                Dictionary<string, User> users = await FirebaseOperations.GetListOfItems<User>("Users");
                foreach (KeyValuePair<string, User> user in users)
                {
                    if (!isUsernameUsed && Equals(user.Value.Username, username))
                    {
                        isUsernameUsed = true;
                    }
                    if (!isEmailUsed && Equals(user.Value.Email, email))
                    {
                        isEmailUsed = true;
                    }
                    if (isUsernameUsed && isEmailUsed)
                    {
                        break;
                    }
                }

                if (!isUsernameUsed && !isEmailUsed)
                {
                    FirebaseOperations.SetItem("Users", new User(username, email, password));
                    MessageBox.Show("Kaydýnýz Baþarýyla Tamamlandý.");
                    panelRegister.Hide();
                    textBoxLoginUsername.Text = username;
                    textBoxLoginPassword.Text = password;

                }
                else if (isUsernameUsed && isEmailUsed)
                {
                    MessageBox.Show("Ayný kullanýcý adý ve e-mail ile kayýtlý bir kullanýcý zaten var.");
                }
                else if (isUsernameUsed)
                {
                    MessageBox.Show("Ayný kullanýcý adý ile kayýtlý bir kullanýcý zaten var.");
                }
                else if (isEmailUsed)
                {
                    MessageBox.Show("Ayný e-mail ile kayýtlý bir kullanýcý zaten var.");
                }
            }
            else if (!new EmailAddressAttribute().IsValid(email) && !new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            {
                MessageBox.Show("Çok göze batýyosun");
            }
            else if (!new EmailAddressAttribute().IsValid(email))
            {
                MessageBox.Show("Emaili düzgün gir.");
            }
            else if (!new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            {
                MessageBox.Show("Kullanýcý adýný düzgün gir.");
            }
        }
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUsername.Text;
            string password = textBoxLoginPassword.Text;
            if (new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
            {
                Dictionary<string, User> users = await FirebaseOperations.GetListOfItems<User>("Users");
                bool isLoginSucces = false;
                bool isMessageBoxShowed = false;
                foreach (KeyValuePair<string, User> user in users)
                {
                    if (Equals(user.Value.Username, username))
                    {
                        if (Equals(user.Value.Password, password))
                        {
                            MessageBox.Show("HLLKE");
                            isLoginSucces = true;
                        }
                        else
                        {
                            MessageBox.Show("Username or password is not correct.");
                            isMessageBoxShowed = true;
                        }
                        break;
                    }
                }
                if (!isMessageBoxShowed && !isLoginSucces)
                {
                    MessageBox.Show("Username or password is not correct.");
                }
            }
            else
            {
                MessageBox.Show("Göze batýyon bak yapma");
            }
        }
    }
}