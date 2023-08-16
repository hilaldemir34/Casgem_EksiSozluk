using EksiSozluk.DtoLayer.Dtos.AppUserDtos;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EksiSozluk.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.UserName,
                    Email = appUserRegisterDto.Email,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.SurName,
                    imageUrl = "ddd",
                    City = "ankara",
                    District = "abc"

                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);//identity için veri ekleme işlemi
                if (result.Succeeded)
                {
                    return Redirect("/Login/Index");
                }
                return View();
              
            }
            return View();
        }
    }
}
