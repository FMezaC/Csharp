using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeveloper
{
    // Tipy Enums
    enum MonthOfYears
    {
        January, Fabrury, March, April, May, June, July, August, September, Octomber, Nobember, December
    }

    // Abstract class
    abstract class Products
    {
        public abstract void getNombre();
    }
    
    //Create classes and Herentia 
    class TableClass : Products, INumePatas
    {
        public override void getNombre()
        {
            Console.WriteLine("I am a table.");
        }
        public int NumeroPatas()
        {
            return 4;
        }
    }

    // Herencia
    class ProducClass : Products, INumePatas, ITipoAsiento
    {
        // Interfaces
        public int NumeroPatas()
        {
            return 4;
        }

        public string FormaAsiento()
        {
            return "Sofá";
        }

        public bool AsientoSala()
        {
            return true;
        }

        //Polimo
        private string Descriptions;
        protected double BuyPrice;
        protected double SalesPrice;

        public override void getNombre()
        {
            Console.WriteLine("I am a chair");
        }
        public ProducClass(string PDescri, double BuyPrice)
        {
            this.Descriptions = PDescri;
            this.BuyPrice = BuyPrice;
            SalesPrice = 0.0;
        }

        // virtual
        public virtual void CalculatePrice()
        {
            Console.WriteLine("Calculate Price of Product");
            SalesPrice = (BuyPrice * 1.3)+BuyPrice;
        }

        public void ListProductSales()
        {
            Console.WriteLine("{0} sales in {1}", Descriptions, SalesPrice);
        }
        
    }
    
    class ProductImported : ProducClass
    {
        protected double impuesto;
        public ProductImported(string PDescri, double PSalesProd, double Pimpuest) : base(PDescri, PSalesProd)
        {
            this.impuesto = Pimpuest;
        }

        // overried
        public override void CalculatePrice()
        {
            SalesPrice = (BuyPrice + (BuyPrice * impuesto)+(BuyPrice * 1.3));
        }
    }

    class ProductStopped : ProductImported
    {
        protected double PenaltyFee;
        public ProductStopped(string PDescrip, double PSalesProd, double PImpuest, double penaltyFee) 
            : base(PDescrip, PSalesProd, PImpuest)
        {
            this.PenaltyFee = penaltyFee;
        }

        //overried
        public override void CalculatePrice()
        {
            SalesPrice = (BuyPrice + (BuyPrice * impuesto) + (BuyPrice * 1.3)) + PenaltyFee;
        }
    }

    class ProductDamaged : ProductImported
    {
        protected double PBrocket;
        public ProductDamaged(string PDescrip, double PSalesProd, double PImpuest, double PBrocket) 
            : base(PDescrip, PSalesProd, PImpuest)
        {
            this.PBrocket = PBrocket;
        }

        // sealed
        public sealed override void CalculatePrice()
        {
            SalesPrice = (BuyPrice + (BuyPrice * impuesto) + (BuyPrice * 1.3)) - (BuyPrice * PBrocket);
        }
    }
}
