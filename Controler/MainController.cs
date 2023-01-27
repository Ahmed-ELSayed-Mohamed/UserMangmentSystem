using Microsoft.AspNetCore.Mvc;
using UserMangmentSystem.Model;

namespace UserMangmentSystem.Controler
{
    public class HomeController  : Controller
    {
        private readonly IEmployeeRepo _employee;

        public HomeController(IEmployeeRepo employee)
        {
            _employee = employee;
        }

        public string Index()
        {
            return _employee.GetById(1).Name;
        }
    }
}
