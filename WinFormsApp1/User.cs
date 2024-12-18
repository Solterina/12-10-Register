using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1;

public class User
{
    //public int Id { get; set; }
    //public string Loggin { get; set; }

    //public string Password { get; set; }

    //public string SecurityQuestion { get; set; }

    //public string SecurityAnswer { get; set; }

    //public User(string loggin, string password, string securityQuestion, string securityAnswer)
    //{
    //    Loggin = loggin;
    //    Password = password;
    //    SecurityQuestion = securityQuestion;
    //    SecurityAnswer = securityAnswer;
    //}
   
    public int Id { get; set; }
    [MaxLength(50)]
   
    public string Username { get; set; }
    [MaxLength(255)]
    public string Password { get; set; }

    public User(string loggin, string ppassword)
    {
        Username = loggin;
        Password = ppassword;
    }
    public User()
    {
        Username = "test";
        Password = "test";
    }
}
