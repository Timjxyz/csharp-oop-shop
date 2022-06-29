using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int code;
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        private int iva = 22;

        public Prodotto(string name, string descrption,double price)
        {
            this.name = name;
            this.description = descrption;
            this.price = price;
           
        }

        public void PrintProduct()
        {
            Console.WriteLine("Nome prodotto : " + this.name);
            Console.WriteLine("Descrizione prodotto : " + this.description);
            Console.WriteLine("Codice Prodotto : " + this.GetCode());
            Console.WriteLine("Prezzo Prodotto : " + this.GetPrice() + "euro");
            Console.WriteLine("Prezzo Prodotto ivato : " + this.GetIvaPrice() + "euro");


        }

        public int GetCode()
        {
            Random random = new Random();
            int code= random.Next(1,99999999);
            return code;
        }

        public double GetPrice()
        {
           
            return this.price;
        }
        public double GetIvaPrice()
        {

            double iva =(this.price*22)/100;

            double priceIva=this.price + iva;
            return priceIva;
        }

    }
}
