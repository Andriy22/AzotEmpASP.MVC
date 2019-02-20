using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site1.Models;

namespace Site1
{
    public class CreateModel
    {
        public CreateModel()
        {
            selectListItems = new List<SelectListItem>();
        }
       
        public string Name { get; set; }

   
        public string SurName { get; set; }


        public int Age { get; set; }


        public int Salary { get; set; }

        [IsLogin]
        public string login { get; set; }


        public string password { get; set; }

        public string Deportament_name { get; set; }

        public ICollection<SelectListItem> selectListItems { get; set; }
    }
}