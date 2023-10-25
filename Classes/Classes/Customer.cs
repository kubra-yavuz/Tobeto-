using System;
namespace Classes
{
	class Customer
	{ 

		//Property
		public int Id { get; set; }

		private string _firstName;
		public string FirstName
		{
			get { return "Mrs" + _firstName; }
			set { _firstName = value; }

		}
		public string LastName { get; set; }
		public string City { get; set; }
		
	}
}

