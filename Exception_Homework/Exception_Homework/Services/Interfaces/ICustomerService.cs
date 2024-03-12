using System;
using Exception_Homework.Models;

namespace Exception_Homework.Services.Interfaces
{
	public interface ICustomerService
	{
		List<Customer> GetAll();
		Customer GetById(int? id=null);
		List<Customer> GetAllByAge(int age);
		int GetCount();
		List<Customer> OrderByAge(string order);
	}
}

