using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinavSistemi2.FluentValidation;

namespace SinavSistemi2.EntityFramework
{
    public class TextEntity:IText

    {
        public string Emailt { get; set; }
        public string Namet { get; set; }
        public string Surnamet { get; set; }
    }
}
