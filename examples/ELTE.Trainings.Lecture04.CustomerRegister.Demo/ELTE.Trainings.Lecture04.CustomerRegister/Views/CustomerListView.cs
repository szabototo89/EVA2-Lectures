using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELTE.Trainings.Lecture04.CustomerRegister.Models;
using ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
    public partial class CustomerListView : UserControl, IInitializable<DataManager>
    {
        public DataManager DataManager { get; protected set; }

        public event SelectedCustomerChangedEventHandler SelectedCustomerChanged;

        public string SearchText
        {
            get
            {
                if (_SearchTextBox != null)
                    return _SearchTextBox.Text;

                return string.Empty;
            }
        }

        public Customer SelectedCustomer
        {
            get
            {
                if (_CustomerListBox == null)
                    return null;

                return _CustomerListBox.SelectedItem as Customer;
            }
        }

        public CustomerListView()
        {
            InitializeComponent();
            _CustomerListBox.SelectedValueChanged += (sender, args) =>
            {
                var listBox = sender as ListBox;

                if (listBox == null)
                    throw new NullReferenceException();

                if (SelectedCustomerChanged != null)
                    SelectedCustomerChanged(this, new CustomerChangedEventArgs(listBox.SelectedItem as Customer));
            };
            _CustomerListBox.DisplayMember = "Name";
        }

        public void Initialize(DataManager manager)
        {
            if (manager == null)
                throw new ArgumentNullException("manager");

            if (_CustomerListBox == null)
                throw new Exception("CustomerListView is not initialized!");

            DataManager = manager;
            UpdateListBoxDataSource(DataManager.Customers);
        }

        private void UpdateListBoxDataSource(IEnumerable<Customer> customers)
        {
            if (customers == null) throw new ArgumentNullException("customers");

            _CustomerListBox.DataSource = customers.Where(customer => customer != null && !string.IsNullOrWhiteSpace(customer.Name))
                                           .Where(customer => customer.Name.ToLower().Contains(SearchText.ToLower()))
                                           .OrderBy(customer => customer.Name)
                                           .ToList();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchText))
                _CustomerListBox.DataSource = DataManager.Customers;

            UpdateListBoxDataSource(DataManager.Customers);
        }

        private void SearchTextBoxEnter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;

            textBox.SelectAll();
        }

        private void AddCustomerButtonClick(object sender, EventArgs e)
        {
            DataManager.AddCustomer("[ New customer ]");
            Initialize(DataManager);
        }

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            var customer = _CustomerListBox.SelectedItem as Customer;
            if (customer == null)
                return;

            DataManager.RemoveCustomer(customer.Name);
            Initialize(DataManager);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            DataManager.ClearCustomers();
            Initialize(DataManager);
        }
    }
}
