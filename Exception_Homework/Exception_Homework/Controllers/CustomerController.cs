using System;
using Exception_Homework.Helpers.Exceptions;
using Exception_Homework.Services;
using Exception_Homework.Services.Interfaces;

namespace Exception_Homework.Controllers
{
	public class CustomerController
	{
		private readonly ICustomerService _customerService;
		public CustomerController()
		{
			_customerService = new CustomerService();
		}

		public void GetAll()
		{
			foreach (var item in _customerService.GetAll())
			{
				Console.WriteLine(item.FullName+" "+item.Age+" "+item.Address);
			}
		}

		public void GetById()
		{
			try
			{
				var result = _customerService.GetById();
				Console.WriteLine(result.FullName + " " + result.Age + " " + result.Address);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void GetAllByAge()
		{
			int age = 21;
			foreach (var item in _customerService.GetAllByAge(age))
			{
				Console.WriteLine(item.FullName + " " + item.Age + " " + item.Address);
			}
		}

		public void GetCound()
		{
			var result = _customerService.GetCount();
			Console.WriteLine(result);
		}

		public void OrderByAge()
		{
			try
			{
                Console.WriteLine("Please choose the text:Ascending or Descending");
                string order = Console.ReadLine();
				if (order.Trim()=="" || order==null)
				{
					throw new NullException("Argument cannot be null please choose and enter again");
				}
                foreach (var item in _customerService.OrderByAge(order))
                {
                    Console.WriteLine(item.FullName + " " + item.Age + " " + item.Address);
                }
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}

