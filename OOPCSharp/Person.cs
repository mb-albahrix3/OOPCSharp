using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    class Person
    {

        //Varibales 
        string firstname, lastname ,country;

       
       
        //Proprties
        public string FirstName
        {

            get { return firstname; }
            set { firstname = value;  }

        }

        public string LastName {


            get {return lastname; } 
            set { lastname = value;} 
        
        
        }

        public DateTime birthdate { get; set; }


        public string Country
        {


            get { return country; }
            set { country = value; }


        }
    }
}
