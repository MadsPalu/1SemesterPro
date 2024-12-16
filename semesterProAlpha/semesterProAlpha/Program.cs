// See https://aka.ms/new-console-template for more information
using semesterProAlpha;

Medlem medlem1 = new Medlem("Anna Hansen", "12345678", "Bakkenvej 5");
Medlem medlem2 = new Medlem("Bjørn Jensen", "87654321", "Skovvej 12");
Medlem medlem3 = new Medlem("Clara Nørgaard", "45678912", "Havnegade 34");
Medlem medlem4 = new Medlem("David Sørensen", "23456789", "Markvej 56");
Medlem medlem5 = new Medlem("Eva Larsen", "98765432", "Strandvej 78");

MedlemsRepository.AddMedlem(medlem1);
MedlemsRepository.AddMedlem(medlem2);
MedlemsRepository.AddMedlem(medlem3);
MedlemsRepository.AddMedlem(medlem4);
MedlemsRepository.AddMedlem(medlem5);

MedlemsRepository.PrintListe();

// Create Båd objects
Båd båd1 = new Båd("Havfruen", "Motorbåd", "Volvo Penta", 2010, "10*3*2");
Båd båd2 = new Båd("Sølvpilen", "Sejlbåd", "Bavaria Cruiser", 2018, "12*3.5*2.5");
Båd båd3 = new Båd("Blåhvalen", "Robåd", "Fisker", 2005, "4*1.5*1");
Båd båd4 = new Båd("Vindrosen", "Sejlbåd", "Hunter", 2020, "14*4*3");
Båd båd5 = new Båd("Lynet", "Motorbåd", "Mercury", 2015, "8*2.5*2");

// Add Båd objects to the repository
BådRepository.AddBåd(båd1);
BådRepository.AddBåd(båd2);
BådRepository.AddBåd(båd3);
BådRepository.AddBåd(båd4);
BådRepository.AddBåd(båd5);

BådRepository.PrintListe();

// Chairman objecter
ChairMan chairMan1 = new ChairMan(1, "Henning");
ChairMan chairMan2 = new ChairMan(2, "Lars");

chairMan1.chairManLog.Add(chairMan1.Id, chairMan1);
chairMan2.chairManLog.Add(chairMan2.Id, chairMan2);

Console.WriteLine("Chairmen:");
chairMan1.GetChairmanLog(1);
chairMan2.GetChairmanLog(2);
Console.WriteLine();

