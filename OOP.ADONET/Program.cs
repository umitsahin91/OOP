using OOP.ADONET.DAL.Concrete.ADONET;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;


namespace OOP.ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            var _productDal = new ProductDal();
            //var product = new Product { ProductName = "Tea", UnitPrice = 30, UnitsInStock = 1000 };
            //_productDal.Add(product);
            // _productDal.Delete(new Product { ProductId=78});
            _productDal.Update(new Product { ProductId = 77,UnitPrice=45,UnitsInStock=1000});

            _productDal.GetAll().ForEach(p => Console.WriteLine($"{p.ProductId} {p.ProductName} {p.UnitPrice}" ));

            
        }

        private static void Delete()
        {
            Employee employee = new Employee() { EmployeeId = 1012 };
            new EmployeeDal().Delete(employee);
        }

        private static void Update()
        {
            Employee employee = new Employee() { EmployeeId = 1014, FirstName = "Mehmet", LastName = "Demir" };
            new EmployeeDal().Update(employee);
        }

        private static void Read()
        {
            new EmployeeDal()
                .GetAll()
                .ForEach(e => Console.WriteLine(e));       
        }

        private static void Create()
        {
            Employee employee = new Employee() { FirstName = "Enes", LastName = "Güzel" };
            new EmployeeDal().Add(employee);
        }
    }
}
