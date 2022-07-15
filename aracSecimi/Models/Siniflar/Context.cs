using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aracSecimi.Models.Siniflar
{
    public class Context : DbContext
    {
       public DbSet<Iletisim> Iletisims { get; set; }
       public DbSet<Hakkimizda> Hakkimizdas { get; set; }
       public DbSet<Admin> Admins { get; set; }
       public DbSet<Arac> Aracs { get; set; }
       public DbSet<AracSoru> AracSorus { get; set; }
       
    }
}   