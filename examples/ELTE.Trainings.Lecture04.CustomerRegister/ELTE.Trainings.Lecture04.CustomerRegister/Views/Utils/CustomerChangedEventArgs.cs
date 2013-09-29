using System;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils
{
	public class CustomerChangedEventArgs : EventArgs
	{
		public Customer Customer { get; private set; }

		public CustomerChangedEventArgs(Customer customer)
		{
			Customer = customer;
		}
	}
}