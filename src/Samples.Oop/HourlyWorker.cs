using Samples.Oop;
using System;
using System.Text;

namespace Samples.Oop {
	public class HourlyWorker : Employee {

		private decimal wage;
		private double hoursWorked;

		public HourlyWorker(string firstName, 
            string lastName, 
            double hoursWorked, 
            decimal wage) : base(lastName,firstName){
                this.HoursWorked = hoursWorked;
                this.Wage = wage;
		}

		public override decimal Earnings(){
            if (HoursWorked <= 40){
                return Wage * Convert.ToDecimal(HoursWorked);
            }
            else {
                decimal basePay = Wage * Convert.ToDecimal(40);
                decimal overtimePay = Wage * 1.5M * Convert.ToDecimal(HoursWorked - 40);
                return basePay + overtimePay;
            }
		}

        public override string Details()
        {
            StringBuilder buf = new StringBuilder();
            buf.AppendFormat("\tHours worked:\t\t[ {0} ]\n",this.HoursWorked);
            buf.AppendFormat("\tWage:        \t\t[ {0} ]",this.Wage);
            return buf.ToString();
        }

		public decimal Wage
        {
			get{ return wage;  }
			set{ wage = (value > 0 ? value : 0); }
		}

		public double HoursWorked{
			get{ return hoursWorked;  }
			set{ hoursWorked = (value >= 0 && value < 168 ? value : 0); }
		}
	}
}