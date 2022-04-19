using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class User
    {
        public string FullName;
        public string Password;
        public string Email;

        //Encapsulation
        //private string email;

        //public string email
        //{
        //    get
        //    {
        //        return email;
        //    }
        //    set
        //    {
        //        email = value;
        //    }
        //}
        public User(string FullName, string PassWord, string Email)
        {
            this.FullName = FullName;
            this.Password = PassWord;
            this.Email = Email;
        }
    }
}
