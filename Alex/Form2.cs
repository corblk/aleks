using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alex
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfirmPage confirm = new ConfirmPage();
            confirm.ShowDialog();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(this.LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);
            string ConfirmPassword = Convert.ToString(ConfirmPasswordBox.Text);
            bool ConfirmIsSuccess = Password == ConfirmPassword; 

            if (Login  == "" | Password == "" | ConfirmPassword  == "")
            {
                label6.Visible = true;
                label6.Text = "Введите данные";
            };

            if (ConfirmIsSuccess == false) 
            {
                label6.Visible = true;
                label6.Text = "Пороли не совпадают!";
            };
            
           if (Login != "" & Password != "" & ConfirmPassword != "" & ConfirmIsSuccess == true)
           {
                this.Hide();
                ConfirmPage confirm = new ConfirmPage();
                confirm.ShowDialog();
           };
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
