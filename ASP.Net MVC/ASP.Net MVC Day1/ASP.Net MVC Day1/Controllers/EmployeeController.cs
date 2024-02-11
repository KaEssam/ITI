using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.Net_MVC_Day1.Models;

namespace ASP.Net_MVC_Day1.Controllers
{
    public class EmployeeController: Controller
    {
        public string Welcome()
        {
            return "Welcome";
        }

        public JsonResult All()
        {
            return Json(CompanyDBContext.Employees, JsonRequestBehavior.AllowGet);
        }

        public RedirectToRouteResult add(int id, string name)
        {
            CompanyDBContext.Employees.Add(new Employee() { ID = id, Name = name });
            return RedirectToAction("All");
        }

        public RedirectToRouteResult Update(int id, string newName)
        {
            var exictingEmployee = CompanyDBContext.Employees.FirstOrDefault(e => e.ID == id);

                exictingEmployee.Name = newName;

                return RedirectToAction("All");
        }

        public RedirectToRouteResult Remove(int id)
        {
            var EmployeeToRemove = CompanyDBContext.Employees.FirstOrDefault(e => e.ID == id);

            
                CompanyDBContext.Employees.Remove(EmployeeToRemove);

            return RedirectToAction("All");
        }
    }
}