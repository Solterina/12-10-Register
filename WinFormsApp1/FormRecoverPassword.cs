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
    public partial class FormRecoverPassword : Form
    {
        UserDbContext db;
        User user;
        public FormRecoverPassword()
        {
            InitializeComponent();
            db = new UserDbContext();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (db.Users.FirstOrDefault(user => user.Loggin == txtRecoverLogin.Text) is User _user)
            {
                blQuestion.Text = _user.SecurityQuestion;
                blQuestion.Visible = true;
                txtAnswer.Visible = true;
                btnSubmitAnswer.Visible = true;

                user = _user;
            }
            else
            {
                MessageBox.Show("Неверный логин. Попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == user.SecurityAnswer)
            {
                lblRecoveredPassword.Text = $"Ваш пароль: {user.Password}";
                lblRecoveredPassword.Visible = true;
            }
           else
            {
                MessageBox.Show("Неверный ответ на контрольный вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
