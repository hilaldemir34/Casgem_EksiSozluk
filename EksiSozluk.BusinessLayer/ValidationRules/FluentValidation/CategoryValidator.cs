﻿using EksiSozluk.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        { 
        RuleFor(x=>x.CategoryName).NotEmpty();  
        }  
    }
}
