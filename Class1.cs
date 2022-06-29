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
            this.code= new Random().Next(0, 99999999);

        }

        //Metodo per stampare prodotti a video
        public void PrintProduct()
        {
            Console.WriteLine("Nome prodotto : " + this.name);
            Console.WriteLine("Descrizione prodotto : " + this.description);
            Console.WriteLine("Codice Prodotto : " + this.code);
            Console.WriteLine("Prezzo Prodotto : " + this.GetPrice() + "euro");
            Console.WriteLine("Prezzo Prodotto ivato : " + this.GetIvaPrice() + "euro");
            Console.WriteLine("Nome esteso : " + this.GetNameExtended());


        }

        //Metodo get prezzo
        public double GetPrice()
        {
           
            return this.price;
        }

        //Metodo per calcolo iva
        public double GetIvaPrice()
        {

            double iva =(this.price*22)/100;
            double priceIva=this.price + iva;
            return priceIva;
        }

        //Metodo per avere il nome esteso(nome+codice)
        public string GetNameExtended()
        {
            this.name= this.name.Replace(" ", "-");
            string nameExtended= String.Format("{0}"+"-"+"{1}",this.name,this.code);
            return nameExtended;
        }

        //Parte bonus
        public string GetBonus()
        {
            string newChar = "";

            if (this.code.ToString().Length < 8)
            {
                for (int i = this.code.ToString().Length; i < 8; i++)
                {
                    newChar += "0";

                }
                newChar += this.code.ToString();
                return newChar;
            }
            else
            {
                return this.code.ToString();
            }
        }

        }
}
