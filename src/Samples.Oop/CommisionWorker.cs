using System;
using System.Text;
using Samples.Oop;

namespace Samples.Oop {
	public class CommissionWorker : Employee {

		private decimal salary;
		private decimal commission;
		private int totalsItemsSold;

		public CommissionWorker(string firstName, 
            string lastName, 
            int quantity, 
            decimal commission, 
            decimal salary): base(lastName,firstName){
                this.Salary = salary;
                this.Commission = commission;
                this.TotalsItemsSold = quantity;
		}

		public override decimal Earnings(){
            return Salary + Commission * TotalsItemsSold;
		}

        public override string Details()
        {
            StringBuilder buf = new StringBuilder();
            buf.AppendFormat("\tSalary:   \t\t[ ${0} ]\n",this.Salary);
            buf.AppendFormat("\tCommision:\t\t[ {0} ]\n",this.Commission);
            buf.AppendFormat("\tItem sold:\t\t[ {0} ]",this.TotalsItemsSold);
            return buf.ToString();
        }

		public decimal Salary{
			get{ return salary;  }
			set{ salary = (value > 0 ? value : 0); }
		}

		public decimal Commission{
			get{ return commission;  }
			set{ commission = (value > 0 ? value : 0); }
		}

		public int TotalsItemsSold{
			get{ return totalsItemsSold; }
			set{ totalsItemsSold = (value > 0 ? value : 0); }
		}
	}//end CommissionWorker

}//end namespace Samples.Oop