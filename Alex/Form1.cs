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
    
public partial class ConfirmPage : Form
    {
        public ConfirmPage()
        {
            InitializeComponent();
        }

        public bool admin = new bool();

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);
            
            
      

            if (Login == "" | Password == "")
            {
                label5.Visible = true;
                label5.Text = "Введите данные";
            };

            if (Login == "admin" | Password == "admin")
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.ChangeButton.Visible = true;
                mainPage.SaveButton.Visible = true;
                mainPage.DeleteButton.Visible = true;
                mainPage.AddButton.Visible = true;
                mainPage.LableLogin.Text = Login;
                mainPage.ShowDialog();
            }
            else if (Login != "" & Password != "")
            {
                this.Hide();
                MainPage mainPageUser = new MainPage();
                mainPageUser.LableLogin.Text = Login;
                mainPageUser.ShowDialog();
            };
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPage reg = new RegistrationPage();
            reg.ShowDialog();
        }

        
    }
}
