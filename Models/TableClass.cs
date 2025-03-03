using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ruanStudyGroup.Models
{
    public class TableClass
    {
        [Display(Name  = "Student Number")]  //Decorator
        public string StudentID { get; set; }


        [Display(Name = "Name")]  //Decorator
        public string FirstName { get; set; }


        [Display(Name = "Surname")]  //Decorator
        public string LastName { get; set; }


        [Display(Name = "Email Address")]  //Decorator
        public string EmailAdress { get; set; }

    }
}