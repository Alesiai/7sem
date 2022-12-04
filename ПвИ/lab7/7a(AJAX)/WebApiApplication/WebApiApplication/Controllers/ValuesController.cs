using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiApplication.Controllers
{
    
    public class ValuesController : ApiController
    {
        PhoneBookContext context = new PhoneBookContext();
        
        
      
        public IEnumerable<Note> GetNotes()
        {
            return context.Notes;
        }

        public Note GetNote(int id)
        {         
            return context.GetNote(id);
        }

        [HttpPost]
        public void AddNote([FromBody] Note note)
        {
            context.Add(note);
    
        }

        [HttpPut]
        public void UpdateNote(int id, [FromBody] Note note)
        {
            context.Update(id, note);
        }

        public void DeleteNote(int id)
        {
            context.Delete(id);
        }
    }
}
