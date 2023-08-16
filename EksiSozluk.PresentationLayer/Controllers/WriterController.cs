using EksiSozluk.DtoLayer.Dtos.AppUserDtos;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public  async Task< IActionResult> Index()
        {
            var values = await  _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto= new AppUserEditDto();
            appUserEditDto.Name = values.Name;
            appUserEditDto.Surname = values.Surname;    
            appUserEditDto.PhoneNumber= values.PhoneNumber; 
            appUserEditDto.Email = values.Email;
            appUserEditDto.City = values.City;
            appUserEditDto.District = values.District;
            appUserEditDto.ImageUrl = values.imageUrl;
             
            return View(appUserEditDto);
        }
    }
}
