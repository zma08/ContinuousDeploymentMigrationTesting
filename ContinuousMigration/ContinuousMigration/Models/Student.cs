namespace ContinuousMigration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [Display(Name = "Major")]
        public string major { get; set; }

        [StringLength(20)]
        public string hobby { get; set; }

    }
}
