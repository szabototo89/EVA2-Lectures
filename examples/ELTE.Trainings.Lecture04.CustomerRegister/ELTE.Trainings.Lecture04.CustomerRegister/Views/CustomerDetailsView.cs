using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	public partial class CustomerDetailsView : UserControl, IInitializable<Customer>
	{
		public event CustomerSavedEventHandler CustomerSaved;

		protected Customer Customer { get; set; }

		public CustomerDetailsView()
		{
			InitializeComponent();
			_BirthDateTimePicker.MaxDate = DateTime.Now;
		}

		public void Initialize(Customer customer)
		{
			if (customer == null) throw new ArgumentNullException("customer");

			Customer = customer;

			_NameTextBox.Text = customer.Name ?? "Type customer name here";

			if (customer.BirthDate < _BirthDateTimePicker.MinDate || customer.BirthDate > _BirthDateTimePicker.MaxDate)
				_BirthDateTimePicker.Value = DateTime.Now.AddDays(-1);
			else
				_BirthDateTimePicker.Value = customer.BirthDate;

			_AddressDetailsView.Initialize(customer.Address ?? new Address());
			_JobDetailsView.Initialize(customer.Job ?? new Job());
		}

		public Customer GetCustomer()
		{
			return Customer;
		}

		private void UpdateCustomer(Customer customer)
		{
			if (customer == null) throw new ArgumentNullException("customer");

			customer.Name = _NameTextBox.Text;
			customer.BirthDate = _BirthDateTimePicker.Value;
			customer.Address = _AddressDetailsView.GetAddress();
			customer.Job = _JobDetailsView.GetJob();
		}

		private void SaveCustomerButtonClick(object sender, EventArgs e)
		{
			SaveCustomer();
		}

		public void SaveCustomer()
		{
			UpdateCustomer(Customer);
			if (CustomerSaved != null)
				CustomerSaved(this, new CustomerChangedEventArgs(Customer));
		}
	}
}
