using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Db.crud;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DictController : Controller
    {
        private UserContextFactory userFactory = new UserContextFactory();

        // GET: Dict
        public ActionResult Index()
        {
            List<User> users = userFactory.GetAll();
            users.Sort((u1, u2) => u1.Name.CompareTo(u2.Name));
            return View(users);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult AddSave(User user)
        {
            userFactory.Create(user);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(long? Id)
        {
            if (Id != null)
                return View(userFactory.GetOneById((int)Id.Value));
            else
                return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult UpdateSave(User user)
        {
            userFactory.Update(user);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(long? Id)
        {
            ViewBag.Id = Id;
            return View();
        }
        [HttpPost]
        public ActionResult DeleteSave(long? Id)
        {
            userFactory.Delete((int)Id.Value);
            return RedirectToAction("Index");
        }



    }
}