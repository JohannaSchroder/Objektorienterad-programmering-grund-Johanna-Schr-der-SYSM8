using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FIT_TRACK
{
    class User : Person//Ärver från Person
    {
        //egenskaper
        public string Country { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }

        //konstruktor
        public User(string UserName, string Password, string Country, string SecurityQuestion, string SecurityAnswer) : base(UserName, Password)
        { 
            this.Country = Country;
            this.SecurityQuestion = SecurityQuestion;
            this.SecurityAnswer = SecurityAnswer;
        }

        //metoder
        public override void SignIn()//HÄR BEHÖVER DU LÄGGA IN KOD!!
        {
            if (UserName == UserName && Password == Password)
            {
                MessageBox.Show("Du är inloggad!");
            }
            else
            {
                MessageBox.Show("Kontrollera ditt Användarnamn och Lösenord");
            }
        }

        /*public void ResetPassword(string securityAnswer)//HÄR BEHÖVER DU LÄGGA IN KOD OM DU VILL FÅ VG!!
        { 
            
        }*/
    }
}
