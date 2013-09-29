namespace ELTE.Trainings.Lecture04.CustomerRegister.Models
{
	public class Job
	{
		public EmployeeType EmployeeType { get; set; }
		public Company Company { get; set; }

		public Job()
		{
			Company = new Company();
		}
	}
}