using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SinavSistemi2.EntityFramework;

namespace SinavSistemi2.FluentValidation
{
    class ProductValidator:AbstractValidator<TextEntity>
    {
        public ProductValidator()
        {

            RuleSet("Names", () =>
            {
                RuleFor(p => p.Namet).MinimumLength(3);
                RuleFor(p => p.Surnamet).MinimumLength(3);
            });
            RuleSet("Email", () =>
            {
                RuleFor(p => p.Emailt).EmailAddress();
                RuleFor(p => p.Emailt).MinimumLength(10);
            });
        }
    }
}
