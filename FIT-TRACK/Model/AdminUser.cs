using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK
{
    class AdminUser : User //Ärver från User
    {
        //Egenskap
        

        //Konstruktor
        public AdminUser(string UserName, string Password, string Country, /*string SecurityQuestion, string SecurityAnswer*/) 
            : base(UserName, Password, Country /*SecurityQuestion, SecurityAnswer*/) 
        { 
        }

        //Metod
        public override void SignIn()//HÄR BEHÖVER DU FYLLA I KOD!!
        {
            
        }

        public void MenageAllWorkouts()//HÄR BEHÖVER DU FYLLA I KOD!!
        { 
        
        }
    }
}
