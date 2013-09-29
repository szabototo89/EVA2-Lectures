using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	public partial class JobDetailsView : UserControl, IInitializable<Job>
	{
		private readonly Dictionary<string, EmployeeType> _EmployeeTypes = new Dictionary<string, EmployeeType>() {
			{ "intern", EmployeeType.Intern },
			{ "contractor", EmployeeType.Contractor },
			{ "graduated", EmployeeType.Graduated },
			{ "manager", EmployeeType.Manager },
			{ "vice president", EmployeeType.VicePresident },
		};

		public JobDetailsView()
		{
			InitializeComponent();
			_EmployeeTypeComboxBox.DataSource = _EmployeeTypes.Keys.ToList();
		}

		public void Initialize(Job job)
		{
			if (job == null) 
				throw new ArgumentNullException("job");

			if (job.Company == null)
				throw new NullReferenceException("Company cannot be null!");

			_CompanyNameTextBox.Text = job.Company.Name ?? "[Type company name here ...]";
			_CompanyAddressDetailsView.Initialize(job.Company.Address ?? new Address());

			_EmployeeTypeComboxBox.SelectedItem = _EmployeeTypes.Where(pair => pair.Value == job.EmployeeType)
																.Select(pair => pair.Key)
																.First();
		}

		public Job GetJob()
		{
			Job job = new Job() {
				EmployeeType = _EmployeeTypes[_EmployeeTypeComboxBox.SelectedItem.ToString()],
				Company = new Company() {
					Name = _CompanyNameTextBox.Text,
					Address = _CompanyAddressDetailsView.GetAddress()
				}
			};

			return job;
		}
	}
}
