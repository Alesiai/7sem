using Microsoft.AspNetCore.Mvc;
using PhoneBookCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookCore.Controllers
{
    [Route("api")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private IPhoneDictionary repo;
        public WebApiController(IPhoneDictionary r)
        {
            repo = r;
        }

        // GET api/
        [HttpGet]
        public ActionResult Select()
        {
            var telephones = repo.SelectAll();
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // GET api/5
        [HttpGet("{id:int}")]
        public ActionResult Getone(int id)
        {
            var telephones = repo.SelectById(id);
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // POST api/
        [HttpPost]
        public ActionResult Post(Phone telephone)
        {
            bool flag = repo.Insert(telephone.Name, telephone.PhoneNumber);

            if (flag)
            {
                return Ok(telephone);
            }
            else
            {
                return NoContent();
            }
        }

        // PUT api/
        [HttpPut]
        public ActionResult Put(Phone telephone)
        {
            bool flag = repo.Update(telephone.Id, telephone.Name, telephone.PhoneNumber);

            if (flag)
            {
                return Ok(telephone);
            }
            else
            {
                return NoContent();
            }
        }

        // DELETE api/5
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            bool flag = repo.Delete(id);

            if (flag)
            {
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

    }
}
