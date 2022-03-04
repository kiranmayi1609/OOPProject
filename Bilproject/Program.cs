using Bilproject.BilData;
//using Bilproject.Bilmodels;


// test Del 1 opgave 1/5 her 
//Motokøretøj motokøretøj = new Motokøretøj();
//Motokøretøj motokøretøj = new Bil();
//Motokøretøj motokøretøj = new Audi();
//Audi audi =new Audi();
//Audi audi = new Bil();
//Audi audi = new Motokøretøj();
 bil = new Bil();
//opret lister af model klassserne 

List<Bil> bilers = new()
{
    new Bil() { Mærke = "Toyoto", Model = "Aygo", HesteKræfter = 60 },
    new Bil() { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
    new Bil() { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
};

foreach (var data in bilers)
    Console.WriteLine(data.Mærke + ", " + data.HesteKræfter);

