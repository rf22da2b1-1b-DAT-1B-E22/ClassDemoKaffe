// See https://aka.ms/new-console-template for more information

using ClassDemoKaffe;

Console.WriteLine("Velkommen til kaffe shoppen");

// lave nogle objekter / instanser


// type         objektnavn    nyt objekt     kalder konstruktør
Kaffe           espresso     = new           Kaffe();

Console.WriteLine(espresso.ToString());


Kaffe nyKaffe = new Kaffe("Etiopien", "Arabica", 56.5);
Console.WriteLine(nyKaffe.ToString());


nyKaffe.Price = 60;
nyKaffe.PrisMedMoms(); // kalder metoder laver udregn men ellers intet

Console.WriteLine(nyKaffe.ToString());
Console.WriteLine("Pris med moms = " + nyKaffe.PrisMedMoms());

double pris = nyKaffe.PrisMedMoms();
Console.WriteLine("pris = " + pris);


// kunde - køb  - kaffe
Kunde kunde = new Kunde("Peter");

Koeb køb = new Koeb(kunde, nyKaffe);

Console.WriteLine("købet er " + køb.ToString());




