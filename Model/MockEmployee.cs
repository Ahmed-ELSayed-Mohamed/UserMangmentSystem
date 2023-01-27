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
            new Employee( ) { Id =1,Name="ahmed",Salary=400000},
            new Employee( ) { Id =2,Name="Mohamed",Salary=500000},
             new Employee( ) { Id =3,Name="Heba",Salary=800000}

        };
        }

        public Employee GetById(int id)
        {
            throw new System.NotImplementedException();
            return _Employess.FirstOrDefault(e=> e.Id == id);
        }
    }
}
