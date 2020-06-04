namespace PasswordVault {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.signUpUserControl1 = new PasswordVault.SignUpUserControl();
            this.forgotPasswordUserControl1 = new PasswordVault.ForgotPasswordUserControl();
            this.loginUserControl1 = new PasswordVault.LoginUserControl();
            this.SuspendLayout();
            // 
            // signUpUserControl1
            // 
            this.signUpUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpUserControl1.Location = new System.Drawing.Point(0, 0);
            this.signUpUserControl1.Name = "signUpUserControl1";
            this.signUpUserControl1.Size = new System.Drawing.Size(484, 361);
            this.signUpUserControl1.TabIndex = 0;
            // 
            // forgotPasswordUserControl1
            // 
            this.forgotPasswordUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPasswordUserControl1.Location = new System.Drawing.Point(0, 0);
            this.forgotPasswordUserControl1.Name = "forgotPasswordUserControl1";
            this.forgotPasswordUserControl1.Size = new System.Drawing.Size(484, 361);
            this.forgotPasswordUserControl1.TabIndex = 1;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUserControl1.Location = new System.Drawing.Point(0, 0);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(484, 361);
            this.loginUserControl1.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.loginUserControl1);
            this.Controls.Add(this.forgotPasswordUserControl1);
            this.Controls.Add(this.signUpUserControl1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SignUpUserControl signUpUserControl1;
        private ForgotPasswordUserControl forgotPasswordUserControl1;
        private LoginUserControl loginUserControl1;
    }
}