using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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
            string enteredPassword = Convert.ToHexString(SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(txtPassword.Text)));

            if (enteredLogin == "" || enteredPassword == "")
            {
                lblResult.Text = "Введите логин и пароль, пожалуйста";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }

            else if (db.users.Any(user => user.Username == enteredLogin && user.Password == enteredPassword))
            {
                lblResult.Text = "Успешная авторизация";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
            else
            {
                lblResult.Text = "Неверный логин или пароль. Попробуйте снова.";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
    
            txtLogin.Clear();
            txtPassword.Clear();

            txtLogin.Focus();
            lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string enteredLogin = txtLogin.Text;
            string enteredPassword = Convert.ToHexString(SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(txtPassword.Text)));

            if (enteredLogin =="" || enteredPassword=="")
            {
                lblResult.Text = "Введите логин и пароль, пожалуйста";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                return;
            }

            var user = new User(enteredLogin, enteredPassword);

            if(db.users.Any(user => user.Username == enteredLogin))
            {
                lblResult.Text = "Пользователь с такимим именем уже существут";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                return;
            }
            

            db.users.Add(user);
            db.SaveChanges();

            lblResult.Text = "Вы успешно зарегистрировались";

            txtLogin.Clear();
            txtPassword.Clear();

            txtLogin.Focus();
            lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
        }
    }
}
