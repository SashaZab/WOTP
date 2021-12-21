using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Lab_Zab.Models.Contact;

namespace Lab_Zab.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> CreateContact(ContactViewModel vm)
        { 
            if(!ModelState.IsValid)
            {
                return View("ContactUs");
            }
            return View("ContactUs");
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
            
