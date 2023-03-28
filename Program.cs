using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            User.Login = "12345";
            User.LoginLength = Convert.ToInt32(User.Login.Length);

            Console.WriteLine("Длина логина {0}", User.LoginLength);
            Console.ReadKey();
        }
    }
}
