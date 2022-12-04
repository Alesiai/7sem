using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using lab03.Controllers;
using Newtonsoft.Json;

namespace lab03.Models
{
    public class PhoneBookContext
    {
        public List<PhoneBook> phoneBooks = new List<PhoneBook>();
        string Path;
        public PhoneBookContext(string path)
        {
            Path = path;
            if (File.Exists(path))
            {
                using (StreamReader fs = new StreamReader(path))
                {
                    JsonTextReader jsonTextReader = new JsonTextReader(fs);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    phoneBooks = jsonSerializer.Deserialize<List<PhoneBook>>(jsonTextReader);
                    phoneBooks.Sort((p1, p2) => p1.Surname.CompareTo(p2.Surname));
                }
            }
        }
        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, phoneBooks);
            }
        }
        public void Add(string surname, string telephone)
        {
            int last_id = phoneBooks.Max(p => p.Id);
            PhoneBook phoneBook = new PhoneBook() {Id = last_id + 1, Surname = surname, TelephoneNumber = telephone };
            phoneBooks.Add(phoneBook);
            phoneBooks.Sort((p1, p2) => p1.Surname.CompareTo(p2.Surname));
            Save();
        }
        public void Update(int id, string surname, string telephone)
        {
            for(int item = 0; item < phoneBooks.Count; item++)
            {
                if (phoneBooks[item].Id == id)
                {
                    phoneBooks[item].Surname = surname;
                    phoneBooks[item].TelephoneNumber = telephone;
                    break;
                }
            }
            phoneBooks.Sort((p1, p2) => p1.Surname.CompareTo(p2.Surname));
            Save();
        }
        public void Delete(int id)
        {
            for (int item = 0; item < phoneBooks.Count; item++)
            {
                if (phoneBooks[item].Id == id)
                {
                    phoneBooks.RemoveAt(item);
                    break;
                }
            }
            phoneBooks.Sort((p1, p2) => p1.Surname.CompareTo(p2.Surname));
            Save();
        }
    }
}