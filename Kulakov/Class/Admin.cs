using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulakov.Class
{
    class Admin
    {
        int id { get; set; }
        string name { get; set; }
        string login { get; set; }
        string password { get; set; }
        int role { get; set; }

        public void Say()
        {
            Console.WriteLine("Администратор вошел в систему.");
        }

    }
}
