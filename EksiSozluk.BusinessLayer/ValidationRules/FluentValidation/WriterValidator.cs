using EksiSozluk.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Yazar isim alanı boş geçilemez");  
            RuleFor(x=>x.SurName).NotEmpty().WithMessage("Yazar soyisim alanı boş geçilemez");  
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Yazar email alanı boş geçilemez");  
            RuleFor(x=>x.Phone).NotEmpty().WithMessage("Telefon numarası giriniz");  
            RuleFor(x=>x.Phone).NotEmpty().WithMessage("Telefon numarası giriniz");  

        }
    }
}
