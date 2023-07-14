using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values=_contactService.TGetAll();
            return View(values);
        }


        public IActionResult DeleteContact(int id)
        {
            var values=_contactService.TGetById(id);
            _contactService.TRemove(values);
            return RedirectToAction("Index");
        }

        public IActionResult GetMessageByTesekkur()
        {
            var values=_contactService.TGetContactBySubjectWithTesekkur();
            return View(values);
        }


        [HttpGet]
        public IActionResult SendMessage()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.TAdd(contact);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
