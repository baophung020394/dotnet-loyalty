namespace loyaltyentity.DBA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bp_customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string firstname { get; set; }

        [Required]
        [StringLength(255)]
        public string surname { get; set; }

        [StringLength(255)]
        public string address1 { get; set; }

        [StringLength(255)]
        public string address2 { get; set; }

        [StringLength(255)]
        public string address3 { get; set; }

        [StringLength(255)]
        public string address4 { get; set; }

        [Required]
        [StringLength(255)]
        public string postcode { get; set; }

        [StringLength(255)]
        public string telephone { get; set; }

        public int? age { get; set; }

        public DateTime? Created_at { get; set; }

        public DateTime? Updated_at { get; set; }
    }
}
