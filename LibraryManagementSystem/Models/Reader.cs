using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Reader : User
    {
        public Reader(string name) : base(name)
        {

        }
       

        public override void ShowPermissions()
        {
            Console.WriteLine("здравствуйте, вы можете брать и возвращать книги");
        }
    }
}
