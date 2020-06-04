using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault {
    public partial class LoginUserControl : UserControl {
        LoginForm loginForm = new LoginForm();
        public LoginUserControl() {
            InitializeComponent();
        }

        private void lblSignUp_Click(object sender, EventArgs e) {
            //How to pass data between forms
            //Need to know how to switch to the other usercontrol but that data is in LoginForm
        }
    }
}
