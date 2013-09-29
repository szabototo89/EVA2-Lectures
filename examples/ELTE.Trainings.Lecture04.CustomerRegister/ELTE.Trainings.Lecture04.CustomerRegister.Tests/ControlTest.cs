using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Tests.Utils;
using ELTE.Trainings.Lecture04.CustomerRegister.Views;
using NUnit.Framework;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Tests
{
	[TestFixture]
	public class ControlTest
	{
		public Address Address { get; private set; }
		public Job Job { get; private set; }
		public IEnumerable<Customer> Customers { get; private set; }

		private DateTime GetRandomDateTime()
		{
			var random = new Random();
			return new DateTime(random.Next(1910, 2000), random.Next(1, 12), random.Next(1, 28));
		}

		[SetUp]
		public void SetupTest()
		{
			Address = new Address() {
				City = "Budapest",
				Country = "Hungary",
				Postcode = "1117",
				StreetAddress = "Pázmány Péter sétány"
			};

			Job = new Job() {
				EmployeeType = EmployeeType.Intern,
			};

			Customers = new List<Customer>() {
				new Customer() {
					Name = "Tony Stark", BirthDate = GetRandomDateTime(),
					Address = Address, Job = Job
				},
				new Customer() {
					Name = "Steve Rogers", BirthDate = GetRandomDateTime(),
					Address = Address, Job = Job
				},
				new Customer() {
					Name = "Nick Fury", BirthDate = GetRandomDateTime(),
					Address = Address, Job = Job
				},
				new Customer() {
					Name = "Bruce Banner", BirthDate = GetRandomDateTime(),
					Address = Address, Job = Job
				}
			};
		}

		[Test]
		public void CustomerListViewTest()
		{
			var customerListView = new CustomerListView();
			customerListView.Initialize(new DataManager(Customers));

			using (var testForm = new UserControlTestForm(customerListView))
			{
				testForm.ShowDialog();
			}
		}

		[Test]
		public void AddressListViewTest()
		{
			var addressDetailsView = new AddressDetailsView();
			addressDetailsView.Initialize(Address);

			using (var testForm = new UserControlTestForm(addressDetailsView)) {
				testForm.ShowDialog();

				var address = addressDetailsView.GetAddress();
				Console.WriteLine(address.City);
				Console.WriteLine(address.Country);
				Console.WriteLine(address.Postcode);
				Console.WriteLine(address.StreetAddress);
			}
		}

		[Test]
		public void JobDetailsViewTest()
		{
			var jobDetailsView = new JobDetailsView();
			jobDetailsView.Initialize(Job);

			using (var testForm = new UserControlTestForm(jobDetailsView)) {
				testForm.ShowDialog();

				var job = jobDetailsView.GetJob();
			}
		}
		
		[Test]
		public void CustomerRegisterTest()
		{
			using (var customerRegister = new MainForm())
				customerRegister.ShowDialog();
		}
	}
}
