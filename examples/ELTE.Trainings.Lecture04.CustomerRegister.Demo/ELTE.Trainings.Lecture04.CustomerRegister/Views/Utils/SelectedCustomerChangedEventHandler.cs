namespace ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils
{
	public delegate void SelectedCustomerChangedEventHandler(object sender, CustomerChangedEventArgs args);

	public delegate void CustomerSavedEventHandler(object sender, CustomerChangedEventArgs args);
}