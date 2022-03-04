
//using Quiz;
using Quiz.Bildata;
//----------------------------------------------------------------------DEL 1------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------1/5-------------------------------------------------------------------------------------------
//Motokøretøj motokøretøj = new Motokøretøj();
//Motokøretøj motorKøretøj = new Bil();
//Motokøretøj motokøretøj = new Audi();
//Audi audi=new Audi();
//Audi audi=new Bil();
//Audi audi = new Motokøretøj();
// ------------------------------------------------------------------------2/5----------------------------------------------------------------------------------------------
//Opgave 1: vis med de 3 bil data til højre ,hvordan i kan indkapsle bil dataerne i et objekt og indkapsle  flere bil data objekter 
//Answer: 
//List<Bil> bil = new()
//{
//    new Bil { Mærke = "Toyoto", Model = "Aygo", HesteKræfter = 60 },
//    new Bil { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
//    new Bil { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
//};

////Opgave 2:vis med LINQ hvordan i kan udskrive all bilers 
//Bil Car = bil.FirstOrDefault(a => a.HesteKræfter == 90);
//Bil Car1 = bil.FirstOrDefault(a => a.HesteKræfter == 175);
//Console.WriteLine($"{Car.Mærke},{Car.Model}");
//Console.WriteLine($"{Car.Mærke},{Car.Model}");

//Opgave 3:Vis  med LINQ hvordan i kan udskrive alle bilers info 
// Answer : 
//Bil Car2 = Biler.FirstOrDeafult(a => a.Mærke == "Audi");
//Console.WriteLine($"{Car2.Mærke},{Car2.Model},{Car2.HesteKræfter}");


//--------------------------------------------------------------------------3/5--------------------------------------------------------------------------------------------
// Opgave 1:Hvilket af de kode linjer foroven returner en List<Bil>
//Answer:??=Biler.Where(.....);

//Opgave 2:Hvilket af de linjer  foroven returner en enkelt Bil objekt ?
//Answer: ??=??=Biler.FirstOrDefault(------);
//        ??=Biler.First(------------)


//Opgave 3:Hvilket af de 3 kode linjer foroven returner null værdi --------------
//Answer :?? Biler.Where(.....);
//
// Opgave 4:Hvilket af de 3 kode linjer foroven vil CRASH applikationen hvis ingen match funket i søge kondition?
//Answer: ??=Biler.FirstOrDefault(------);
//        ??=Biler.First(------------)




//-------------------------------------------------------------------------4/5------------------------------------------------------------------------------------------------
//Alle bil skal have vægtafgift ,derfor bør den ligge i bil klassen.Men man ved ikke hvordan man skal implementer kode til udregning af vægt afgift i Bil klassen fordi det er afhængigt af bilens mærke og model .som parent 
//klasse  kan bil klasse ikke se data i child klassen .Hvad skal man gøre her ?
// answer : Brug abstrakt,fordi 






//---------------------------------------------------------------------------5/5-----------------------------------------------------------------------------------------
//Opgave : Angiv hvilken method til venstre er overloaded
//Answer : Setsyn er overloaded,fordi den står af 2 methoder 