using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DAL;
namespace Site1
{
    public class IsUniqAttribute : ValidationAttribute
    {
        DBase ctx = new DBase();
        public override bool IsValid(object value)
        {


            var res = ctx.Emps.FirstOrDefault(x => x.login == value);
            if (res != null)
                return true;
            else
                return false;
             
        }
    }
}