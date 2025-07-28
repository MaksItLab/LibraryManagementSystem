using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces
{
    public interface IJsonStorage
    {
        void Save(List<Models.Book> data, string filePath);
        List<Models.Book> Load(string filePath);
    }
}
