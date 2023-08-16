using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
 
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            var values = _usersService.TGetList();
            return View(values);
        }


        //public IActionResult UserProfile(int id)
        //{
        //    var value = _writerService.TGetById(id);
        //    return View(value);
        //}
    }
}
