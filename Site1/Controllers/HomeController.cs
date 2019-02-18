using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
namespace Site1.Controllers
{
    public class HomeController : Controller
    {
        DAL.DBase ctx = new DAL.DBase();
        public ActionResult Index()
        {
            ICollection<IndexModel> model = new List<IndexModel>();

            foreach (var el in ctx.Emps)
                model.Add(new IndexModel
                {
                    Age = el.Age,
                    Deportament_desc = el.Deportament.Description,
                    Deportament_name = el.Deportament.Name,
                    Name = el.Name,
                    Salary = el.Salary,
                    SurName = el.SurName
                });
            return View(model);

        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Create( )
        //{
        //    return View();
         
        //}


    }
}