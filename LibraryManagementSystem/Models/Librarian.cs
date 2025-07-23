using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Librarian : User
    {
        public Librarian(string name, string Librarian) : base(name)
        {
            Role = Librarian;
        }

        public override void ShowPermissions()
        {
            Console.WriteLine("здравствуйте, вы можете добавлять и удалять книги");
        }
    }
}
