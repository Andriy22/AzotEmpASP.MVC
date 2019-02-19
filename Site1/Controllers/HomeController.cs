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
                    Deportament_desc = el.deportament.Description,
                    Deportament_name = el.deportament.Name,
                    Name = el.Name,
                    Salary = el.Salary,
                    SurName = el.SurName
                });
            return View(model);

        }
        public ActionResult Create()
        {
            CreateModel model = new CreateModel();
            foreach (var el in ctx.Deportaments)
                model.selectListItems.Add(new SelectListItem() { Text = el.Name, Value = el.Name });
            return View(model);
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

        [HttpPost]
        public ActionResult Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                ctx.Emps.Add(new Emp
                {
                    Age = model.Age,
                    Name = model.Name,
                    deportament = ctx.Deportaments.FirstOrDefault(x => x.Name == model.Deportament_name),
                    login = model.login,
                    password = model.password,
                    Salary = model.Salary,
                    SurName = model.SurName
                });
                ctx.SaveChanges();
                return Redirect("/");
            }
            else
                return View();

        }


    }
}