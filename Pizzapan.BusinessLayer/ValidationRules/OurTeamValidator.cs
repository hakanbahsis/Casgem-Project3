using FluentValidation;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.ValidationRules
{
    public class OurTeamValidator:AbstractValidator<OurTeam>
    {
        public OurTeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş geçilemez!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Fotoğraf boş geçilemez!");
        }
    }
}
