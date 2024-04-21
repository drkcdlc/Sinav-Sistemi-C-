using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi2.EntityFramework
{
    class TableAdder:IAdder
    {
        public void Add(TableEntity tableEntity)
        {
            using (ExamContext context = new ExamContext())
            {
                var entity = context.Entry(tableEntity);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
