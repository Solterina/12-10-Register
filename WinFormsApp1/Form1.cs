using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int correcterror = 3;
        UserDbContext db;

        public Form1()
        {
            InitializeComponent();
            db = new UserDbContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredLogin = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            if (correcterror <= 0)
            {
                lblResult.Text = "У вас закончились попытки входа!";
                lblResult.ForeColor = Color.Red;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
            else if (db.Users.Any(user => user.Loggin == enteredLogin && user.Password == enteredPassword))
            {
                lblResult.Text = "Успешная авторизация";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                correcterror = 3;
            }
            else
            {
                lblResult.Text = $"Неверный логин или пароль. Попробуйте снова.\n Попыток осталось {correcterror}";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                correcterror--;
            }
            txtLogin.Clear();
            txtPassword.Clear();

            txtLogin.Focus();
            lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegister();
            formRegister.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            var formRecoverPassword = new FormRecoverPassword();
            formRecoverPassword.Show();
        }
    }
}
