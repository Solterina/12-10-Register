using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1;

public class User
{
    public int Id { get; set; }
    public string Loggin { get; set; }

    public string Password { get; set; }

    public string SecurityQuestion { get; set; }

    public string SecurityAnswer { get; set; }

    public User(string loggin, string password, string securityQuestion, string securityAnswer)
    {
        Loggin = loggin;
        Password = password;
        SecurityQuestion = securityQuestion;
        SecurityAnswer = securityAnswer;
    }
}
