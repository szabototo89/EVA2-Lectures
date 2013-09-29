using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Models
{
	public sealed class DataManager
	{
		private List<Customer> _Customers;

		public IEnumerable<Customer> Customers
		{
			get { return _Customers; }
			private set { _Customers = value.ToList(); }
		}

		public DataManager(IEnumerable<Customer> customers)
		{
			if (customers == null)
				throw new ArgumentNullException("customers");

			Customers = customers;
		}

		public DataManager AddCustomer(string name)
		{
			_Customers.Add(new Customer() { Name = name });
			return this;
		}

		public DataManager RemoveCustomer(string name)
		{
			var index = _Customers.FindIndex(customer => customer.Name == name);
			if (index != -1)
				_Customers.RemoveAt(index);

			return this;
		}

		public DataManager ClearCustomers()
		{
			_Customers.Clear();
			return this;
		}
	}
}
