namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class transaction
    {
        public int id { get; set; }

        public double? amount { get; set; }

        [StringLength(100)]
        public string reference { get; set; }

        public DateTime? date { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? AccountType { get; set; }
    }
}
