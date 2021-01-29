namespace loyaltyentity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerCF
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        [Required]
        public int? age { get; set; }

       [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}",
            ApplyFormatInEditMode = true)]
        public DateTime Created_at { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}",
            ApplyFormatInEditMode = true)]
        public DateTime Updated_at { get; set; }
    }
}
