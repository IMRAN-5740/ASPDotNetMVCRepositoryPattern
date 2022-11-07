using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPDotNetMVCRepositoryApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Provide your Student Name"), MinLength(5)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide your Student Name")]
        [Display(Name = "Registration")]
        public string RegNo { get; set; }
        [Required(ErrorMessage = "Please Provide your Student Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide your Student Address")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Please Provide your Student City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Provide your Student Department")]
        [Display(Name ="Department Name")]
        public string Department { get; set; }

    }
}