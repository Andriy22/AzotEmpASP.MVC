using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1
{
    public class CreateModel
    {
        public CreateModel()
        {
            selectListItems = new List<SelectListItem>();
        }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name should be [2 20] symbols")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "SurName should be [2 20] symbols")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Field is Required")]

        [Range(18, 60, ErrorMessage = "Field should be [18 and 60]")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Field is Required")]
        [Range(10000, 99999999, ErrorMessage = "Salary should be [10000 and 99999999]")]

        public int Salary { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "login should be [5 20] symbols")]
        [IsUniq(ErrorMessage ="Login exist")]
        public string login { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "password should be [5 20] symbols")]
        public string password { get; set; }

        public string Deportament_name { get; set; }

        public ICollection<SelectListItem> selectListItems { get; set; }
    }
}