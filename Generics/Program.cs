using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Rize", "Artvin", "Trabzon");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "İsrafil" },
                new Customer { FirstName = "Tomris" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }

    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product : IProductDal
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Product Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    interface IProductDal:IRepository<Product>
    {

    }
    class Customer : ICustomerDal
    {
        public string FirstName { get; set; }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    interface ICustomerDal:IRepository<Customer>
    {

    }

    interface IRepository<T> where T:class,new()
    {
        List<T> GetAll();
        T Get(int Id);
        void Add();
        void Delete();
        void Update();
    }

}
