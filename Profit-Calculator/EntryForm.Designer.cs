namespace Profit_Calculator
{
    partial class EntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonGoBackToLogin = new System.Windows.Forms.Button();
            this.pictureBoxLogoRegister = new System.Windows.Forms.PictureBox();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGoToRegisterForm = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.panelLogin.Controls.Add(this.panelRegister);
            this.panelLogin.Controls.Add(this.textBoxLoginUsername);
            this.panelLogin.Controls.Add(this.textBoxLoginPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonGoToRegisterForm);
            this.panelLogin.Controls.Add(this.pictureBoxLogo);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogin.Location = new System.Drawing.Point(0, 35);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(310, 411);
            this.panelLogin.TabIndex = 0;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.textBoxRegisterEmail);
            this.panelRegister.Controls.Add(this.textBoxRegisterUsername);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.buttonGoBackToLogin);
            this.panelRegister.Controls.Add(this.pictureBoxLogoRegister);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(310, 411);
            this.panelRegister.TabIndex = 10;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.textBoxRegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRegisterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(8, 164);
            this.textBoxRegisterEmail.MaxLength = 35;
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.PlaceholderText = "E-Mail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(295, 25);
            this.textBoxRegisterEmail.TabIndex = 13;
            this.textBoxRegisterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.textBoxRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(8, 200);
            this.textBoxRegisterUsername.MaxLength = 25;
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.PlaceholderText = "Username";
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(295, 25);
            this.textBoxRegisterUsername.TabIndex = 9;
            this.textBoxRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.textBoxRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(8, 237);
            this.textBoxRegisterPassword.MaxLength = 25;
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PlaceholderText = "Password";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(295, 25);
            this.textBoxRegisterPassword.TabIndex = 10;
            this.textBoxRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRegisterPassword.UseSystemPasswordChar = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonRegister.FlatAppearance.BorderSize = 3;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonRegister.Location = new System.Drawing.Point(108, 293);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(94, 38);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonGoBackToLogin
            // 
            this.buttonGoBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonGoBackToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonGoBackToLogin.FlatAppearance.BorderSize = 3;
            this.buttonGoBackToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonGoBackToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonGoBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonGoBackToLogin.Location = new System.Drawing.Point(108, 337);
            this.buttonGoBackToLogin.Name = "buttonGoBackToLogin";
            this.buttonGoBackToLogin.Size = new System.Drawing.Size(94, 39);
            this.buttonGoBackToLogin.TabIndex = 12;
            this.buttonGoBackToLogin.Text = "Back";
            this.buttonGoBackToLogin.UseVisualStyleBackColor = false;
            this.buttonGoBackToLogin.Click += new System.EventHandler(this.buttonGoBackToLogin_Click);
            // 
            // pictureBoxLogoRegister
            // 
            this.pictureBoxLogoRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogoRegister.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoRegister.Image")));
            this.pictureBoxLogoRegister.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoRegister.Name = "pictureBoxLogoRegister";
            this.pictureBoxLogoRegister.Size = new System.Drawing.Size(310, 198);
            this.pictureBoxLogoRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoRegister.TabIndex = 14;
            this.pictureBoxLogoRegister.TabStop = false;
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.textBoxLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.textBoxLoginUsername.Location = new System.Drawing.Point(8, 200);
            this.textBoxLoginUsername.MaxLength = 25;
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.PlaceholderText = "Username";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(295, 25);
            this.textBoxLoginUsername.TabIndex = 5;
            this.textBoxLoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.textBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(8, 237);
            this.textBoxLoginPassword.MaxLength = 25;
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PlaceholderText = "Password";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(295, 25);
            this.textBoxLoginPassword.TabIndex = 6;
            this.textBoxLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.BorderSize = 3;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonLogin.Location = new System.Drawing.Point(108, 293);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 38);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGoToRegisterForm
            // 
            this.buttonGoToRegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonGoToRegisterForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonGoToRegisterForm.FlatAppearance.BorderSize = 3;
            this.buttonGoToRegisterForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonGoToRegisterForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonGoToRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToRegisterForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonGoToRegisterForm.Location = new System.Drawing.Point(108, 337);
            this.buttonGoToRegisterForm.Name = "buttonGoToRegisterForm";
            this.buttonGoToRegisterForm.Size = new System.Drawing.Size(94, 39);
            this.buttonGoToRegisterForm.TabIndex = 8;
            this.buttonGoToRegisterForm.Text = "Sign Up";
            this.buttonGoToRegisterForm.UseVisualStyleBackColor = false;
            this.buttonGoToRegisterForm.Click += new System.EventHandler(this.buttonGoToRegisterForm_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(310, 198);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonExit.Location = new System.Drawing.Point(275, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 29);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(310, 446);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EntryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EntryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EntryForm_MouseUp);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogin;
        private PictureBox pictureBoxLogo;
        private Button buttonGoToRegisterForm;
        private Button buttonLogin;
        private TextBox textBoxLoginPassword;
        private TextBox textBoxLoginUsername;
        private Button buttonExit;
        private Panel panelRegister;
        private TextBox textBoxRegisterEmail;
        private Button buttonGoBackToLogin;
        private Button buttonRegister;
        private TextBox textBoxRegisterPassword;
        private TextBox textBoxRegisterUsername;
        private PictureBox pictureBoxLogoRegister;
    }
}