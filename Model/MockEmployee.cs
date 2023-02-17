using System.Collections.Generic;
using System.Linq;

namespace UserMangmentSystem.Model
{
    public class MockEmployee : IEmployeeRepo
    {
        private List<Employee> _Employess;
        public MockEmployee()
        {
            _Employess = new List<Employee>()
        {
            new Employee( ) { Id =1,Name="ahmed",Salary=400000,Email="ahmed@gmail.com",Department="IT"},
            new Employee( ) { Id =2,Name="Mohamed",Salary=500000,Email="Mohamed@gmail.com",Department="Mangment"},
             new Employee( ) { Id =3,Name="Heba",Salary=800000,Email="heba@gmail.com",Department="IT"}

        };
        }

        public Employee GetById(int id)
        {
            return _Employess.FirstOrDefault(e=> e.Id == id);
        }
    }
}
