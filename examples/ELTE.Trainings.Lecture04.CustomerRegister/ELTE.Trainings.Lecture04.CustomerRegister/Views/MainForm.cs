using System.Collections.Generic;
using System.Windows.Forms;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	public partial class MainForm : Form
	{
		public DataManager DataManager { get; private set; }

		public MainForm()
		{
			DataManager = new DataManager(new List<Customer>() {
				new Customer() { Name = "Gipsz Jakab" },
				new Customer() { Name = "Mekk Elek" }
			});

			InitializeComponent();
			InitializeControls();
		}

		private void InitializeControls()
		{
			_CustomerDetailsView.Enabled = false;
			_CustomerDetailsView.CustomerSaved += CustomerDetailsViewCustomerSaved;
			_CustomerListView.Initialize(DataManager);
			_CustomerListView.SelectedCustomerChanged += CustomerListViewSelectedCustomerChanged;
		}

		private void CustomerDetailsViewCustomerSaved(object sender, CustomerChangedEventArgs args)
		{
			_CustomerListView.Initialize(DataManager);
		}

		public void CustomerListViewSelectedCustomerChanged(object sender, CustomerChangedEventArgs args)
		{
			if (args.Customer == null)
			{
				_CustomerDetailsView.Enabled = false;
			}
			else
			{
				_CustomerDetailsView.Enabled = true;
				_CustomerDetailsView.Initialize(args.Customer);
			}
		}
	}
}
