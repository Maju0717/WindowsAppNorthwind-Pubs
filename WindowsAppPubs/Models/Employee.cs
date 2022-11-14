namespace WindowsAppPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [StringLength(9)]
        public string EmpId { get; set; }

        [Required]
        [StringLength(20)]
        public string FName { get; set; }

        [StringLength(1)]
        public string Minit { get; set; }

        [Required]
        [StringLength(30)]
        public string LName { get; set; }

        public short JobId { get; set; }

        public byte? JobLvl { get; set; }

        [Required]
        [StringLength(4)]
        public string PubId { get; set; }

        public DateTime HireDate { get; set; }

        public virtual Job Job { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
