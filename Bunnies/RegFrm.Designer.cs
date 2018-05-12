namespace Bunnies
{
    partial class RegFrm
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(29, 159);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(207, 23);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Sign up!";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(38, 35);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(33, 13);
            this.loginLbl.TabIndex = 6;
            this.loginLbl.Text = "Login";
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(124, 32);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(100, 20);
            this.loginTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(124, 58);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(38, 61);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(124, 84);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(100, 20);
            this.fNameTxt.TabIndex = 3;
            // 
            // fNameLbl
            // 
            this.fNameLbl.Location = new System.Drawing.Point(38, 87);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(64, 13);
            this.fNameLbl.TabIndex = 8;
            this.fNameLbl.Text = "First Name";
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(124, 110);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lNameTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // RegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 212);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.signUpBtn);
            this.Name = "RegFrm";
            this.Text = "RegFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.Label label4;
    }
}