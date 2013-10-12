using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Models
{
	public class Customer
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }

		public Address Address { get; set; }
		public Job Job { get; set; }
	}				
}
