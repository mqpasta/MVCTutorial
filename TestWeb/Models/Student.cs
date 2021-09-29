using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb.Models
{
    public class Student
    {
        public static List<Student> StudentList = new List<Student>();

        [Required]
        [DisplayName("Name")]
        public string StudentName { get; set; }
        [Required]
        [DisplayName("Father")]
        public string FatherName { get; set; }
        public decimal CGPA { get; set; }
        public int Age { get; set; }

    }
}
