using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_PDF.Models
{
    public class AlunoContext : DbContext
    {
        
        public AlunoContext() : base("name=AlunoContext")
        {
        }

        public DbSet<Aluno> Alunoes { get; set; }
    }
}
