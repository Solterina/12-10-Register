using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegister : Form
    {
        private string newLogin;
        private string newPassword;
        private string securityQuestion;
        private string securityAnswer;
        UserDbContext db;

        public string GetLogin() { return newLogin; }
        public string GetPassword() { return newPassword; }
        public string GetSecurityQuestion() {  return securityQuestion; }
        public string GetSecurityAnswer() {  return securityAnswer; }
        public FormRegister()
        {
            InitializeComponent();
            db = new UserDbContext();
        }
        
        private void btnConfirmRegister_Click(object sender, EventArgs e)
        {
            newLogin = txtNewLogin.Text;
            newPassword = txtNewPassword.Text;
            securityQuestion = txtQuestion.Text;
            securityAnswer = txtAnswer.Text;
            

            if (string.IsNullOrEmpty(newLogin) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(securityQuestion) || string.IsNullOrEmpty(securityAnswer))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Регистрация прошла успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var user = new User(txtNewLogin.Text, txtNewPassword.Text, txtQuestion.Text, txtAnswer.Text);
                
                db.Users.Add(user);
                db.SaveChanges();

                Close();
            }
        }
    }
}
