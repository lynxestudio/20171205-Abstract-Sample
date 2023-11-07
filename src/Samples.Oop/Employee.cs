using System;

namespace Samples.Oop 
{
	public abstract class Employee {

		private string firstName;
		private string lastName;

		public Employee(string lastName, string firstName){
            this.FirstName = firstName;
            this.LastName = lastName;
		}

        public string FirstName 
        {
            private set { firstName = value; }
            get { return firstName; }
        }
        public string LastName 
        {
            private set { lastName = value; }
            get { return lastName;  }
        }

		public abstract decimal Earnings();
        public abstract string Details();

	}
}