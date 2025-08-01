using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryManagementSystem.Services
{
    public class JsonStorage : IJsonStorage
    {
        public List<Book> Load(string filePath)
        {
            
            //try
            //{
                //filePath = Path.GetFullPath("books.json");
                string jsonString = File.ReadAllText("books.json");
                List<Book> book1 = JsonSerializer.Deserialize<List<Book>>(jsonString);
                return book1;
           // }
           // catch 
           // {
           //     Console.WriteLine("возникла ошибка, проверьте корректность ввода!");
           //     return new List<Book>();
           // }
        }

        public void Save(List<Book> data, string filePath)
        {          
                for (int i = 0; i < data.Count; i++)
                {
                    string jsonString = JsonSerializer.Serialize(data[i]);
                    File.WriteAllText("books.json", jsonString);
                }           
        }
    }
}
