using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.Net_MVC_Day2.Models;

namespace ASP.Net_MVC_Day2.Models
{
    public class EmployeeController: Controller
    {
        public ActionResult index()
        {
            ViewData["CompanyDBContext"] = CompanyDBContext.Employees;
            return View();
        }

        public JsonResult All()
        {
            return Json(CompanyDBContext.Employees, JsonRequestBehavior.AllowGet);
        }

        public ActionResult add(Employee employee)
        {
           CompanyDBContext.Employees.Add(employee);
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {


            ViewData["employee"] = CompanyDBContext.Employees.FirstOrDefault(e => e.ID == id);

            return View();
        }

        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            var exictingEmployee = CompanyDBContext.Employees.FirstOrDefault(e => e.ID == employee.ID);

            if (exictingEmployee != null)
            {
                exictingEmployee.ID = employee.ID;

                exictingEmployee.Name = employee.Name;

                exictingEmployee.Salary = employee.Salary;

                exictingEmployee.Age = employee.Age;

                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Remove(int id)
        {
            var EmployeeToRemove = CompanyDBContext.Employees.FirstOrDefault(e => e.ID == id);

            
                CompanyDBContext.Employees.Remove(EmployeeToRemove);

            return RedirectToAction("index");
        }
    }
}