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
	public partial class AddressDetailsView : UserControl, IInitializable<Address>
	{
		public AddressDetailsView()
		{
			InitializeComponent();
		}

		public void Initialize(Address address)
		{
			if (address == null)
				throw new ArgumentNullException("address");

			UpdateControls(address);
		}

		public Address GetAddress()
		{
			var address = new Address() {
				City = _CityTextBox.Text,
				Country = _CountryTextBox.Text,
				Postcode = _PostCodeTextBox.Text,
				StreetAddress = _StreetTextBox.Text
			};

			return address;
		}

		private void UpdateControls(Address address)
		{
			_CityTextBox.Text = address.City ?? "Type city name here";
			_CountryTextBox.Text = address.Country ?? "Type country name here";
			_PostCodeTextBox.Text = address.Postcode ?? "Type postcode here";
			_StreetTextBox.Text = address.StreetAddress ?? "Type street address here";
		}

		private void CountryTextBoxValidating(object sender, CancelEventArgs e)
		{
			var textBox = sender as TextBox;
			if (textBox == null)
				return;

			if (string.IsNullOrWhiteSpace(textBox.Text))
				e.Cancel = true;
		}
	}
}
