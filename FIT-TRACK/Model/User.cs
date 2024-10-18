using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }

        public void ResetPassword(string securityAnswer)//HÄR BEHÖVER DU LÄGGA IN KOD!!
        { 
            
        }
    }
}
