using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {   
        public static void Main(string[] args)
        {
            IAccount account = new IAccount();
            Console.WriteLine("1.Programı başlat");
            Console.WriteLine("2.Programdan çıx");
            byte choose = Convert.ToByte(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    account.Start();
                    break;
               case 2:
                    account.End();
                    break;
            }

        }
    }
}
