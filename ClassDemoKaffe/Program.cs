// See https://aka.ms/new-console-template for more information

using ClassDemoKaffe;

Console.WriteLine("Velkommen til kaffe shoppen");

// lave nogle objekter / instanser


// type         objektnavn    nyt objekt     kalder konstruktør
Kaffe           espresso     = new           Kaffe();

Console.WriteLine(espresso.ToString());


Kaffe nyKaffe = new Kaffe("Etiopien", "Arabica", 56.5);
Console.WriteLine(nyKaffe.ToString());


nyKaffe.Price = -60;
nyKaffe.PrisMedMoms(); // kalder metoder laver udregn men ellers intet

Console.WriteLine(nyKaffe.ToString());
Console.WriteLine("Pris med moms = " + nyKaffe.PrisMedMoms());

double pris = nyKaffe.PrisMedMoms();
Console.WriteLine("pris = " + pris);


// kunde - køb  - kaffe
Kunde kunde = new Kunde("Peter");

Koeb køb = new Koeb(kunde, nyKaffe);

Console.WriteLine("købet er " + køb.ToString());


bool solskin = false;
bool søndag = false;

if (solskin && søndag)
{
    Console.WriteLine("onkel giver IS");
}

int alder = 9;

if (13 <= alder && alder <= 19)
{
    Console.WriteLine("Vedkommende er teenager");
}
else
{
    if (alder < 13)
    {
        Console.WriteLine("vedkommende er barn");

    }
    else
    {
        Console.WriteLine("Vedkommende er voksen");
    }
}




