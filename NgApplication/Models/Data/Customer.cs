namespace NgApplication.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int cust_id { get; set; }

        [StringLength(50)]
        public string app_name { get; set; }

        [StringLength(50)]
        public string cust_name { get; set; }

        [StringLength(50)]
        public string vertical { get; set; }

        [StringLength(50)]
        public string area { get; set; }

        [StringLength(50)]
        public string app_function { get; set; }

        [StringLength(50)]
        public string acc_ownername { get; set; }

        [StringLength(50)]
        public string acc_ownermail { get; set; }

        [StringLength(10)]
        public string target_budget { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual Customer Customer2 { get; set; }
    }
}
