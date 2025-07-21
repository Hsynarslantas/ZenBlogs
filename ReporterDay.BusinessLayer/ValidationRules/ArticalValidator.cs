using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.BusinessLayer.ValidationRules
{
    public class ArticalValidator:AbstractValidator<Artical>
    {
        public ArticalValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Makale başlığı boş geçilemez!");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Makale içeriği boş geçilemez!");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık için  en az 10 karakter girişi yapınız!");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Başlık için  en fazla 100 karakter girişi yapınız!");
            RuleFor(x => x.CategoryId).LessThan(0).WithMessage("Category Id 0 dan küçük olamaz !");
        }
    }
}
