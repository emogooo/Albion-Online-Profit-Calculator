namespace Profit_Calculator
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOkay = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOkay
            // 
            this.buttonOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(23)))));
            this.buttonOkay.FlatAppearance.BorderSize = 2;
            this.buttonOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.buttonOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.buttonOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOkay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonOkay.Location = new System.Drawing.Point(110, 104);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(80, 40);
            this.buttonOkay.TabIndex = 12;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = false;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.labelMessage.Location = new System.Drawing.Point(10, 15);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(280, 80);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 153);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOkay;
        private Label labelMessage;
    }
}