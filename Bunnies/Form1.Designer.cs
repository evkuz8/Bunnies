namespace Bunnies
{
    partial class Form1
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(65, 178);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(167, 23);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Enter!";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(63, 80);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(36, 13);
            this.loginLbl.TabIndex = 1;
            this.loginLbl.Text = "Login:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(63, 133);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password:";
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(132, 72);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(100, 20);
            this.loginTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(133, 130);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 58);
            this.dataGridView1.TabIndex = 5;
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(66, 207);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(167, 23);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "SIGN UP!";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 264);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.enterBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button regBtn;
    }
}

