using EksiSozluk.DtoLayer.Dtos.AppUserDtos;
using EksiSozluk.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.ValidationRules.FluentValidation
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
                RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");  
                RuleFor(x=>x.SurName).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");  
                RuleFor(x=>x.UserName).NotEmpty().MaximumLength(20).WithMessage("Kullanıcı 20 karakterden fazla olamaz.");  
                RuleFor(x=>x.Email).EmailAddress().WithMessage("Lütfen Geçerli bir mail adresi giriniz.");
                RuleFor(x => x.Password).NotEmpty().WithMessage("Password alanı boş geçilemez.");
                RuleFor(x => x.ConfirmPassword).Equal(z=>z.Password).WithMessage("Password eşleşmiyor.");
        }
    }
}
