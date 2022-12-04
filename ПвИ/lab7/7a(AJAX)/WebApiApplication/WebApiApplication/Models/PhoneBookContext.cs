using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PhoneBook.Models
{
    
    public class PhoneBookContext
    {
        public List<Note> Notes = new List<Note>();

        public PhoneBookContext()
        {
            
            using (StreamReader fs = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+"\\notes.json"))
                
            {
                JsonTextReader jsonTextReader = new JsonTextReader(fs);
                JsonSerializer jsonSerializer = new JsonSerializer();
                Notes = jsonSerializer.Deserialize<List<Note>>(jsonTextReader);
                Notes.Sort((surname1, surname2) => surname1.Surname.CompareTo(surname2.Surname));
            }
        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\notes.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Notes);
            }
        }
        public void Add(Note note)
        {
            if (note != null)
            {
                note.Id = Notes.Max(i => i.Id)+1;

                if (!Notes.Any(x => x.PhoneNumber == note.PhoneNumber))
                {
                    Notes.Add(note);
                    Save();
                   
                }
            }
          
        }
    
        public Note GetNote(int id)
        {
            foreach (var note in Notes)
            {
                if (note.Id == id)
                {
                    return note;
                    
                }
            }
         return null;
        }

        public void Update(int id,  Note item)
        {
           
            foreach (var note in Notes)
            {
                if(note.Id == id)
                {
                    Notes.Remove(note);
                    Notes.Add(item);
                    break;
                }
            }
            Notes.Sort((surname1, surname2) => surname1.Surname.CompareTo(surname2.Surname));
            Save();
        }

        public void Delete(int id)
        {
            foreach (var note in Notes)
            {
                if (note.Id == id)
                {
                    Notes.Remove(note);
                    break;
                }
            }
            Notes.Sort((surname1, surname2) => surname1.Surname.CompareTo(surname2.Surname));
            Save();
        }


    }
}