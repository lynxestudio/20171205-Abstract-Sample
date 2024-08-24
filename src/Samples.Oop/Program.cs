using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Oop
{
    class Program
    {
        private static Employee employee;
        private static CommissionWorker commissionWorker;
        private static PieceWorker pieceWorker;
        private static HourlyWorker hourlyWorker;
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" Creating hourlyWorker...");
            hourlyWorker = new HourlyWorker("David", "Hume", 16.75D, 40);
            Console.WriteLine(" Creating pieceWorker...");
            pieceWorker = new PieceWorker("John", "Locke", 40, 0.06M);
            Console.WriteLine(" Creating commissionWorker...");
            commissionWorker = new CommissionWorker("Tomas", "Aquino", 1000, 1.60M, 40);
            Console.WriteLine();
            Console.WriteLine("\tDisplaying employee info    ");
            Console.WriteLine("\t----------------------------------");
            Employee[] employees = { hourlyWorker, pieceWorker, commissionWorker };
            foreach (var item in employees)
            {
                Console.WriteLine("\tFull name:         \t[ {0},{1} ]", item.LastName, item.FirstName);
                Console.WriteLine("{0}",item.Details());
                Console.WriteLine("\tEmployee's earning:\t[ ${0} ]", item.Earnings());
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
