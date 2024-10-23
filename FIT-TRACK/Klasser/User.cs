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

        //konstruktor
        public User(string UserName, string Password, string Country) : base(UserName, Password)
        { 
            this.Country = Country;
        }

        //metoder
        public override void SignIn()
        {           

        }

    }
}
