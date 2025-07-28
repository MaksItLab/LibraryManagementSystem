using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryManagementSystem.Services
{
    public class JsonStorage : IJsonStorage
    {
        public List<Book> Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Book> data, string filePath)
        {
            
            for (int i = 0; i < data.Count; i++) 
            {
                //string jsonString = JsonSerializer.Serialize();
                //File.WriteAllText("books.json", jsonString);
            }
        }
    }
}
