using Microsoft.AspNetCore.Mvc;
using PhoneBookCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookCore.Controllers
{
    public class DictController : Controller
    {
        private IPhoneDictionary repo;
        public DictController(IPhoneDictionary r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View(repo.SelectAll());
        }

        public IActionResult Add()
        {
            return View(repo.SelectAll());
        }

        [HttpPost]
        public IActionResult Add(string surname, string number)
        {
            repo.Insert(surname, number);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View(repo.SelectAll());
        }

        [HttpPost]
        public IActionResult Update(int id, string surname, string number)
        {
            repo.Update(id, surname, number);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View(repo.SelectAll());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
