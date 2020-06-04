namespace PasswordVault {
    partial class ForgotPasswordUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.forgot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.Location = new System.Drawing.Point(214, 153);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(34, 13);
            this.forgot.TabIndex = 0;
            this.forgot.Text = "forgot";
            // 
            // ForgotPasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.forgot);
            this.Name = "ForgotPasswordUserControl";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forgot;
    }
}
