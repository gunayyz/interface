using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class IAccount
    {
        public void PassWordChecker(ref string password)
        {
            bool uzunluq = password.Length >= 8;
            bool boyukHerf = false;
            bool kicikHerf = false;
            bool reqem = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    boyukHerf = true;

                if (char.IsLower(password[i]))
                    kicikHerf = true;

                if (char.IsDigit(password[i]))
                    reqem = true;
            }

            if(!(boyukHerf && uzunluq && reqem && kicikHerf))
            {
                Console.WriteLine("Parolunuzu düzgün daxil edin");
                password = Console.ReadLine();
                PassWordChecker(ref password);
            } 

        }
        public void ShowInfo()
        {
            Console.WriteLine("Userin Adi: " + user.FullName + "\nUserin Emaili: " + user.Email);
        }

        private User user;

        public IAccount()
        {

        }

        public void Start()
        {
            Console.WriteLine("Adinizi və Soyadinizi daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Parolunuzu daxil");
            string password = Console.ReadLine();
            PassWordChecker(ref password);

            Console.WriteLine("Emailinizi daxil edin");
            string email = Console.ReadLine();
               

            user = new User(name, password, email);
            ShowInfo();
        }

        public void End()
        {
            Console.WriteLine("Programdan çıxıldı...");
        }

    }
}
