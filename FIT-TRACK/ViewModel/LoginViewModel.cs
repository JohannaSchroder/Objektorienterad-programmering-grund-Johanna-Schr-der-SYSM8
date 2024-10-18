using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;//hjälpvariabel
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private int _password;
        public int Password
        {
            get { return _password; }
            set 
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public UserDetailWindow LogIn { get; }

        private User _user;
        public LoginViewModel()//HAR FASTNAT HÄR!!!
        {
            _user = new User("admin", "password", "Sverige");
            LogIn = new 
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
   
}
