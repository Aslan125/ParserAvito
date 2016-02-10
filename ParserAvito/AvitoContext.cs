namespace ParserAvito
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AvitoContext : DbContext
    {
        public AvitoContext()
            : base("name=AvitoContext")
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }

        
    }
}
