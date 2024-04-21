using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi2.EntityFramework
{
    interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Results { get; set; }
        public string PassedOrNot { get; set; }
        public string Email { get; set; }
    }
}
