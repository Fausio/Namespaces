using System;
using Namespaces.Admin;
using Namespaces.HR;

namespace Namespaces
{
    #region Explicity creation 
    //namespace MyAppClass
    //{
    //    namespace Admin
    //    {
    //        class Employee
    //        {
    //            public void add() { }
    //            public void update() { }
    //        }
    //    }

    //    namespace HR
    //    {
    //        class Employee
    //        {
    //            public void CalculateSalary() { }
    //        }
    //    }
    //}
    #endregion
    #region Implicity

    namespace Admin
    {
        class Employee
        {
            public void add() { }
            public void update() { }
        }
    }
    namespace HR
    {
        class Employee
        {
            public void CalculateSalary() { }
        }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Admin.Employee employee_Admin = new Admin.Employee();
            employee_Admin.add();
            employee_Admin.update();

            HR.Employee employee_HR = new HR.Employee();
            employee_HR.CalculateSalary();


            Console.ReadKey();
        }
    }
}
