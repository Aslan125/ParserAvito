namespace ParserAvito
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articles
    {
        [Key]
        [StringLength(500)]
        [Required]
        public string Url { get; set; }

        [StringLength(500)]
        public string Numder { get; set; }

        [StringLength(1500)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Info { get; set; }

        [StringLength(500)]
        public string Price { get; set; }

        [StringLength(500)]
        public string Phone { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(500)]
        public string PublicDate { get; set; }
    }
}
