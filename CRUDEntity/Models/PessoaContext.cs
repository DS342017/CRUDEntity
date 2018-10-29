using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDEntity.Models
{
    public class PessoaContext:DbContext
    {
        public DbSet<Models.Pessoa> Pessoa { get; set; }
    }
}