using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using SinavSistemi2.EntityFramework;
using SinavSistemi2.FluentValidation;

namespace SinavSistemi2.Dependancy_Resolvers.Ninject
{
    class BusinessModule:NinjectModule

    {
        public override void Load()
        {
            Bind<IAdder>().To<TableAdder>();
            Bind<IEntity>().To<TableEntity>();
            Bind<IValidator<TextEntity>>().To<ProductValidator>();
            Bind<IText>().To<TextEntity>();
        }
    }
}
