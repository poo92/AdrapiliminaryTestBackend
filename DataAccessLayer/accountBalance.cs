namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountBalance")]
    public partial class accountBalance
    {
        public int id { get; set; }

        public double? rnd { get; set; }

        public double? canteen { get; set; }

        public double? ceocar { get; set; }

        public double? marketing { get; set; }

        public double? parking { get; set; }
    }
}
