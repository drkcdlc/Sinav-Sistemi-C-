using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi2.EntityFramework
{
    class ExamContext:DbContext
    {
        public ExamContext()
        {
            
        }
        public DbSet<TableEntity> TableEntities { get; set; }
    }
}
