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
            StartPosition = FormStartPosition.CenterScreen;
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

            if (new EmailAddressAttribute().IsValid(email) && new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username) && password.Length > 3 && username.Length > 4 && email.Length > 15)
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
                    new CustomMessageBox("Registration completed successfully.").Show();
                    textBoxRegisterUsername.Text = string.Empty;
                    textBoxRegisterPassword.Text = string.Empty;
                    textBoxRegisterEmail.Text = string.Empty;
                    panelRegister.Hide();
                    textBoxLoginUsername.Text = username;
                    textBoxLoginPassword.Text = password;

                }
                else if (isUsernameUsed && isEmailUsed)
                {
                    new CustomMessageBox("There is already a registered user with the same username and e-mail.").Show();
                }
                else if (isUsernameUsed)
                {
                    new CustomMessageBox("There is already a registered user with the same username.").Show();
                }
                else if (isEmailUsed)
                {
                    new CustomMessageBox("There is already a registered user with the same e-mail.").Show();
                }
            }
            else 
            {
                new CustomMessageBox("Invalid input.").Show();
            }
        }
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUsername.Text;
            string password = textBoxLoginPassword.Text;
            if (password.Length > 3 && username.Length > 4 && new Regex("^[a-zA-Z][a-zA-Z0-9]*$").IsMatch(username))
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
                            isLoginSucces = true;
                        }
                        else
                        {
                            new CustomMessageBox("Username or password is not correct.").Show();
                            isMessageBoxShowed = true;
                        }
                        break;
                    }
                }
                if (!isMessageBoxShowed && !isLoginSucces)
                {
                    new CustomMessageBox("Username or password is not correct.").Show();
                }
            }
            else
            {
                new CustomMessageBox("Invalid input.").Show();
            }
        }
    }
}