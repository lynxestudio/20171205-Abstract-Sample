using Samples.Oop;
using System;
using System.Text;

namespace Samples.Oop {
	public class PieceWorker : Employee {

		private decimal wagePerPiece;
		private int quantityPiecesProduced;

		public PieceWorker(string firstName, 
            string lastName, 
            int quantityPiecesProduced, 
            decimal wagePerPiece) : base(lastName,firstName){
                this.QuantityPiecesProduced = quantityPiecesProduced;
                this.WagePerPiece = wagePerPiece;
		}

		public override decimal Earnings(){
            return QuantityPiecesProduced * WagePerPiece;
		}

        public override string Details()
        {
            StringBuilder buf = new StringBuilder();
            buf.AppendFormat("\tPieces produced:\t[ {0} ]\n",this.QuantityPiecesProduced);
            buf.AppendFormat("\tWage per piece: \t[ {0} ]",this.WagePerPiece);
            return buf.ToString();
        }

		public int QuantityPiecesProduced{
			get{ return quantityPiecesProduced;  }
			set{ quantityPiecesProduced = (value > 0 ? value : 0); }
		}

		public decimal WagePerPiece{
			get{ return wagePerPiece;  }
			set{ wagePerPiece = (value > 0 ? value : 0); }
		}
	}//end PieceWorker
}//end namespace Samples.Oop