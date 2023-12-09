using System;

namespace OOPCSharp
{

    class Program
    {



        static void Main()
        {

            //Calling the class Person
            Person person = new Person();

            person.FirstName = "Mubarak";
            person.LastName = "Albahri";
            person.Country = "KW";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.birthdate);

            //Calling the class Bank
            Bank bank = new Bank();

            bank.BankName = "KIB";
            bank.BranchName = "Salmya";
            bank.BranchAdds = "street 13";
            bank.AccNumber = 123456789101112;
            bank.AccCurrency = "KWD";
            bank.Salary = 1500;

            bank.WithDraw(50);
            bank.Desposit(100);
            bank.Transfer(500, 123456789101112);

            //Methods
            DisplayMessageAfterProccess();
            AddTwoParams(5, 5);


            int result = AddTwoParams(5, 5);

            Console.WriteLine($"the results for addtwo params methods =  {result}");


            float resultfloat = subtractTwoNum(10, 5);

            Console.WriteLine($"the results for subtractTwoNum method =  {resultfloat}");

            string firstEMP = "Abdullah", SecondEMP = "mubarak";

            ChangesNames(firstEMP, SecondEMP);

            float x = 75;

            float resultCalculate = Calculate(x);

            Console.WriteLine($"the result of calculation = {resultCalculate}");


            string name = "";

            Console.WriteLine("please , Enter your name ?");
            name = Console.ReadLine();

            if (name == string.Empty)
            {

                WelcomeGuest();

            }
            else
            {

                WelcomeGuest(name);

            }

            string a = "", b = "";
            Console.WriteLine("Please , Enter the first number : ");
            a = Console.ReadLine();

            if (a == string.Empty)
            {

                AddTwoInt();

            }
            else
            {


                Console.WriteLine("Please , Enter the second number : ");
                b = Console.ReadLine();

                int results;
                int.TryParse(a, out int number1);
                int.TryParse(b, out int number2);

                results = AddTwoInt(number1, number2);
                Console.WriteLine($"the result of adding TWO Number in overLoaded functions = {results}");
            }






            //to hides the lines in CMD
            Console.ReadLine();


        }

        //--------------------------------------Methods------------------------------------------------------

        static void DisplayMessageAfterProccess()
        {
            int a = 5, b = 5;

            float result;

            result = a + b;

            Console.WriteLine("the result = " + result);
            Console.WriteLine($"{a} + {b} = {result}");




        }

        static int AddTwoParams(int a, int b)
        {

            int result;

            result = a + b;



            return result;



        }


        static float subtractTwoNum(float a, float b)
        {
            float result;

            result = a - b;

            return result;



        }



        static void ChangesNames(string firstEMP, string SecondEMP)
        {


            Console.WriteLine($"the first EMP = {firstEMP} , the second EMP = {SecondEMP}");

        }

        static float Calculate(float total)
        {
            float result;
            result = 25;
            result += total;

            return result;

        }




        //----------------------------OverLoaded Methods--------------------------------------------------------
        /*
         
         The overloaded methods are functions with same name and diffrent operations and varaibles 
              
         */
        public static void WelcomeGuest()
        {


            Console.WriteLine("How can I help ?");

        }

        public static void WelcomeGuest(string name)
        {

            Console.WriteLine($"How Are you {name}?");

        }

        public static void AddTwoInt()
        {

            Console.WriteLine("the two numbers not added");
        }

        //Optional Value
        public static int AddTwoInt(int a, int b)
        {

            int results = a + b;

            return results;




        }


    }
}
