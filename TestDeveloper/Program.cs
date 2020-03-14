using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types");
            string[] DataType = {"1.-int","2.-long", "3.-Float",
                "4.-double", "5.-char", "6.-bool", "7.-string" };
            for (int i = 0; i < DataType.Length; i++)
            {
                Console.WriteLine(DataType[i]);
            }
            Console.WriteLine("******************************");

            /***************************************
            *       Explicit Casting 
            ***************************************/
            Console.WriteLine("Explicit Casting");
            double myDouble = 9.8;
            Console.WriteLine("Double: " + myDouble);
            int myInt = (int)myDouble;
            Console.WriteLine("Int: " + myInt);
            bool myBool = false;
            Console.WriteLine(Convert.ToString("Bool: " + myBool));

            /***************************************
            *       User Input
            ***************************************/
            Console.WriteLine("Enter Your User Name:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Your User Name is: " + UserName);

            /***************************************
            *       Operators
            ***************************************/
            string[] Operadores = { "Adicion: X + Y", "Substractions: R - Z", "Multiplications: N * N",
                "Divide: J / L", "Moduls: K % H", "Increment: i++", "Decrement: j--" };

            for (int j = 0; j < Operadores.Length; j++)
            {
                Console.WriteLine(Operadores[j]);
            }

            /***************************************
            *       Math
            ***************************************/
            Console.WriteLine("Math.Max(10,6) =" + Math.Max(10,6));
            Console.WriteLine("Math.Min(10,6) =" + Math.Min(10, 6));
            Console.WriteLine("Math.Sqrt(10) =" + Math.Sqrt(10));
            Console.WriteLine("Math.Abs(-10) =" + Math.Abs(-10));
            Console.WriteLine("Math.Round(10.6) =" + Math.Round(10.6));

            /***************************************
            *       Upper And Lower
            ***************************************/
            string text = "Hello world!";
            Console.WriteLine("ToUpper: "+text.ToUpper());
            Console.WriteLine("ToLower: "+text.ToLower());
            Console.WriteLine("Concatenations: " + text.ToUpper()+" And "+text.ToLower());

            /***************************************
            *       Possitions and extracts
            ***************************************/
            string myString = "Hello";
            Console.WriteLine("Positions of 'Hello!'(e): " + myString.IndexOf("e"));
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            int CharPos = txt.IndexOf("V");
            string position = txt.Substring(CharPos,7);
            Console.WriteLine(position);

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            /***************************************
            *       switch, case, do and while
            ***************************************/
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            int r = 0;
            do
            {
                Console.WriteLine("do while: "+r);
                r++;
            }
            while (r < 5);

            /***************************************
            *       for, foreach, breack and continue
            ***************************************/
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                else
                    Console.WriteLine(i);
                continue;
            }

            /***************************************
            *       Arrays
            ***************************************/
            string[] Phones = { "Huawei", "Samsung", "Azumi", "iPhone", "Xaomi", "ZTE" };
            foreach (var item in Phones)
            {
                Console.WriteLine("Mark Phone: " + item);
            }

            /***************************************
            *       Linkq (Max, Min, Sum)
            ***************************************/
            int[] number = { 1, 8, 15, 4 };
            Console.WriteLine("Max: "+number.Max());

            /***************************************
            *       Method static, void, int, bool
            ***************************************/
            string parameter = "USA";
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod("Sweden");
            MyMethod(parameter);

            /***************************************
            *       Call Method overloading
            ***************************************/
            Overloading(1,5);
            Overloading("Hello", "World");

            /***************************************
            *       Call class and objects
            ***************************************/
            MyCarsClass Mustang = new MyCarsClass();
            MyCarsClass Astra = new MyCarsClass();

            Mustang.Model = "Mustang";
            Mustang.Color = "Gray";
            Mustang.Brand = "Toyota";
            Mustang.price = 17000.00;
            Mustang.Year = Convert.ToDateTime("01/01/2020");

            Astra.Model = "Astra";
            Astra.Color = "Red";
            Astra.Brand = "volkswagen";
            Astra.price = 15300.00;
            Astra.Year = Convert.ToDateTime("01/01/2020");
        
            Console.WriteLine(Mustang.Model);
            Console.WriteLine(Astra.Color);
            Console.WriteLine(Astra.Year);
            Mustang.betterCar();

            Mustang.fullThrottle();

            /***************************************
            *       Polymorphism
            ***************************************/
            ProducClass firstClass = new ProducClass("Chair", 65.00);
            firstClass.CalculatePrice();
            firstClass.ListProductSales();
            firstClass.getNombre();

            ProductImported secondClass = new ProductImported("Chair Imported", 65.00, 1.8);
            secondClass.CalculatePrice();
            secondClass.ListProductSales();

            ProductStopped threerdClass = new ProductStopped("Chair Stopped", 65.00, 1.8, 150.00);
            threerdClass.CalculatePrice();
            threerdClass.ListProductSales();

            ProductDamaged fourtClass = new ProductDamaged("Chair Damanged",65.00,1.8,1.5);
            fourtClass.CalculatePrice();
            fourtClass.ListProductSales();

            /***************************************
            *       Abstract and interface
            ***************************************/
            TableClass table = new TableClass();
            table.getNombre();
            Console.WriteLine("Numero de patas: " +table.NumeroPatas());

            /***************************************
            *       enums
            ***************************************/
            MonthOfYears Months = MonthOfYears.March;
            Console.WriteLine(Months);

            MonthOfYears? MyMonths = null;
            Console.WriteLine(MyMonths);

            /***************************************
            *       Predicates
            ***************************************/
            List<int> NumberList = new List<int>();
            NumberList.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Predicate<int> DNumber = new Predicate<int>(NumberPairs);
            List<int> LNumeros = NumberList.FindAll(DNumber);
            foreach (var item in LNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------- Nùmero Primos -----------");

            List<int> PNumber = new List<int>();
            PNumber.AddRange(new int[] { 2, 3,4, 5,6, 7,8,9, 10, 11, 12, 13,14,15, 16, 17,18, 19, 20 });
            Predicate<int> PNumPrimos = new Predicate<int>(NumPrimos);
            List<int> ListPrimos = PNumber.FindAll(PNumPrimos);
            foreach (var item2 in ListPrimos)
            {
                Console.WriteLine(item2);
            }
            /***************************************
            *       Numeros primos
            ***************************************/
            Console.WriteLine("--------- Numeros ------------");
            TableNumbers();

            //Crear Linear
            for (int n = 1; n <= 1; n++) // For para el alto 
            {
                for (r = 1; r <= 20; r++) // For para el ancho
                    Console.Write("*", n);
                Console.WriteLine(" ");
            }

            //Arreglos
            Imprimir();

            Console.ReadLine();
        }
        //Muestra los sueldos de los operarios en el vector sueldos[f]
        static void Imprimir()
        {
            int[] sueldos = new int[] {1000, 1200,1500,2000, 2200 };
            Console.Write("Los 5 sueldos de los aperarios \n");
            for (int f = 0; f < sueldos.Count(); f++)
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
        }

        /***************************************
            *       Numeros pares, compuestos y primos
        ***************************************/
        static void TableNumbers()
        {
            int contador = 0;
            int cantComp = 0;
            int ContPrim = 0;
            int sumComps = 0;
            int sumPrims = 0;
            for (int i = 1; i < 50; i++)
            {
                contador = 0;
                for (int j = 1; j < 50; j++)
                {
                    if (i % j == 0)
                        contador++;
                }
                if (contador >= 3)
                {
                    Console.WriteLine("Numero Compuesto: " + i);
                    cantComp++;
                    sumComps += i;
                }
                //if (i % 2 == 0)
                //    Console.WriteLine("Numero Par: "+i);
                if (contador == 2)
                {
                    Console.WriteLine("Numero Primos: " + i);
                    ContPrim++;
                    sumPrims += i;
                }
            }
            Console.WriteLine("Cantidad de numeros compuesto: "+cantComp);
            Console.WriteLine("Cantidad de Numeros Primos: "+ContPrim);
            Console.WriteLine("Suma de Numeros Compuestos: "+sumComps);
            Console.WriteLine("Suma de Numeros Primos: "+sumPrims);

            for (int x = 2000; x <= 2030; x++)
            {
                if (x % 4 == 0)
                    Console.WriteLine("Año Biciestro: " + x);
            }
            
        }

        /***************************************
            *       Predicates
        ***************************************/
        static bool NumberPairs(int Nmun)
        {
            if (Nmun % 2 == 0)
                return true;
            else
                return false;
        }

        static bool NumPrimos(int Num2)
        {
            if (Num2 == 2)
                return true;
            else if (Num2 % 2 == 0)
                return false;
            else
                return true;
        }

        /***************************************
            *       Metodos
        ***************************************/
        static void MyMethod(string Contry)
        {
            Console.WriteLine(Contry);
        }
        
        /***************************************
            *       Method overloading
        ***************************************/
        static int Overloading (int FN, int SN)
        {
            int sum = FN + SN;
            Console.WriteLine("Total Sum: "+sum);
            return sum;
        }

        static bool Overloading(string FN, string SN)
        {
            if (FN == SN)
            {
                Console.WriteLine("Equal");
                return true;
            }
            else
            {
                Console.WriteLine("Diferent");
                return false;
            }
        }


        public static void FillMatrix(string[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   Console.WriteLine(matrix[i, j]);
                }
            }
        }

        private int[,] mat;
        private void Matricez()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
