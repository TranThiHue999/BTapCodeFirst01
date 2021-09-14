namespace BTapCodeFirst01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [Key]
        public int DeptNo { get; set; }

        [Required]
        [StringLength(30)]
        public string DeptName { get; set; }

        [StringLength(100)]
        public string Note { get; set; }
    }
}
