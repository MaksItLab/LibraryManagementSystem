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
            try
            {
                string jsonString = File.ReadAllText("books.json");
                List<Book> book1 = JsonConvert.DeserializeObject<List<Book>>(jsonString);
                
                return book1;
            }
            catch 
            {
                Console.WriteLine("возникла ошибка, проверьте корректность ввода!");
                return null;
            }

        }

        public void Save(List<Book> data, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
