using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class ContactController : Controller
    {
        //private IContactService _contactService;
        //public ContactController(IContactService contactService)
        //{
        //    _contactService = contactService;
        //}
        ContactManager cm = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.Add(p);

            return RedirectToAction("Index", "Team");
        }
    }
}
