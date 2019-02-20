using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Site1.Models
{
    public class IsLogin : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString() == "Vasyan")
                return true;
            else
                return false;
        }
    }
}