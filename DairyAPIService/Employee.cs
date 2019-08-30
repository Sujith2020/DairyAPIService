namespace DairyAPIService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Key]
        public int EmpId { get; set; }

        public string name { get; set; }

        public DateTime dateofbirth { get; set; }

        public int salary { get; set; }

        public string Gender { get; set; }
    }
}
