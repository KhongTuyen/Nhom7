namespace Seesion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        public bool? rol { get; set; }
    }
}
