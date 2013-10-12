using System.Collections.Generic;
using System.Windows.Forms;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils;
using System;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	public partial class MainForm : Form
	{
        private DateTime GetRandomDateTime()
        {
            var random = new Random();
            return new DateTime(random.Next(1910, 2000), random.Next(1, 12), random.Next(1, 28));
        }

        public MainForm()
        {
            var Address = new Address()
            {
                City = "Budapest",
                Country = "Hungary",
                Postcode = "1117",
                StreetAddress = "Pázmány Péter sétány"
            };

            var Job = new Job()
            {
                EmployeeType = EmployeeType.Intern,
            };

            var Customers = new List<Customer>() {
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

            InitializeComponent();

            _CustomerListView.Initialize(new DataManager(Customers));
        }
	}
}
