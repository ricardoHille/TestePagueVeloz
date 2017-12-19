using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Teste.PagueVeloz.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}