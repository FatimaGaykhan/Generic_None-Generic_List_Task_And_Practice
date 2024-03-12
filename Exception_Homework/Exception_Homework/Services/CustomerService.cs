using System;
using Exception_Homework.Data;
using Exception_Homework.Models;
using Exception_Homework.Services.Interfaces;

namespace Exception_Homework.Services
{
	public class CustomerService:ICustomerService
	{
		

        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id=null)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(string order)
        {
            string newOrder = order.Trim().ToLower();
            List<Customer>? ordered = null;
            if (order == null)
            {

            }
            if (newOrder == "descending")
            {
                ordered = AppDbContext.customers.OrderByDescending(m => m.Age).ToList();
            }
            else if (newOrder == "ascending")
            {
                ordered = AppDbContext.customers.OrderByDescending(m => m.Age).Reverse().ToList();
            }
            return ordered;
        }
    }
}

