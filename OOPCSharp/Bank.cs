using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    class Bank
    {

        //Variables
        public string BankName { get; set; }
        public string BranchName { get; set; }

        public string BranchAdds { get; set; }

        public long AccNumber { get; set; }

        public string AccCurrency { get; set; }

        public decimal Salary{ get; set; }



        //Methods

        public void WithDraw(decimal Amount)
        {

            decimal NewAmount = Salary - Amount;

            if (NewAmount < 0)
            {

                Console.WriteLine("you can't WithDraw");

            }
            else
            {
                Console.WriteLine($"the new Amount = {NewAmount}");
                Console.WriteLine(DateTime.Now);

            }
        }

        public void Desposit(decimal Amount)
        {

            decimal newDeposit = Salary + Amount;

            if(newDeposit > 5000)
            {
                Console.WriteLine("You can't deposit above 5000 KD");
                Console.WriteLine(DateTime.Now);
            }
            else
            {

                Console.WriteLine($"the Salary after deposit = {newDeposit}");
                Console.WriteLine(DateTime.Now);
            }


        }

        public void Transfer(decimal Amount , long _accNumber)
        {

            //search in database
            if (AccNumber == _accNumber)
            {


                decimal newBalance = Salary + Amount;

                Console.WriteLine($"the balance = {newBalance}");

                Console.WriteLine(DateTime.Now);



            }
            else
            {


                Console.WriteLine("ERROR RE-TREY");

            }




        }

    }
    
}
