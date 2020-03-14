using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeveloper
{
    public class MyCarsClass : Cars // herencia
    {
        
        public void betterCar()
        {
            Console.WriteLine("This is the better and race car!");
        }
        public void fullThrottle() // method
        {
            People classInternal = new People();
            classInternal.Name = "Stephano";
            classInternal.Firstname = "stronger";
            classInternal.Lastname = "Lettlegge";
            classInternal.Year = 22;

            Console.WriteLine(classInternal.Name);
            Console.WriteLine(classInternal.Firstname);
            Console.WriteLine(classInternal.Lastname);
            Console.WriteLine(classInternal.Year);
        }
    }

    public class Cars
    {
        //Create a object
        public string Model, Color, Brand; //field
        public double price; // field
        public DateTime Year; // field
    }

    // internal class
    internal class People
    {
        string _name, _firstname, _lastname;
        int _year;
        
        public string Firstname
        {
            get{ return _firstname;}

            set{ _firstname = value;}
        }

        public string Lastname
        {
            get{ return _lastname;}

            set{ _lastname = value;}
        }

        public string Name
        {
            get{ return _name;}

            set { _name = value;}
        }

        public int Year
        {
            get{ return _year;}

            set{ _year = value;}
        }
    }
}
