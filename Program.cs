using csharp_oop_shop;


Console.WriteLine("Elenco prodotti");
Console.WriteLine("*****************************************************************");
//Stampa primo prodotto
Console.WriteLine("PRIMO PRODOTTO");
Prodotto pentola = new Prodotto("Pentola a pressione", "Resistente e affidabile",60);
pentola.PrintProduct();
//Parte Bonus
Console.WriteLine("Eventuale codice generato inferiore agli 8 caratteri "+pentola.GetBonus());

Console.WriteLine("*****************************************************************");
//Stampa secondo prodotto
Console.WriteLine("SECONDO PRODOTTO");
Prodotto sedia = new Prodotto("Sedia da giardino", "Materiale eco sostenibile", 30);
sedia.PrintProduct();
//Parte Bonus
Console.WriteLine("Eventuale codice generato inferiore agli 8 caratteri " + sedia.GetBonus());

Console.WriteLine("*****************************************************************");