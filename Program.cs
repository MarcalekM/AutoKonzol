using AutoKonzol;

List<Auto> autok = Auto.LoadFromCsv("carsData.csv");

var f6 = autok.Where(x => x.HengerekSzama.Equals(8) && x.Gyarto.GyartoNev.Equals("Rolls-Royce") && x.Karosszeria.KarosszeriaNev.Equals("Sedan")).Count();
Console.WriteLine($"6. feladat - 8 hengeres, Rolls-Royce sedanok száma az adott időszakban: {f6} db");

var f7 = autok.OrderByDescending(x => x.Ar).First();
Console.WriteLine($"7. feladat - A legdrágább autó");
Console.WriteLine(autok.IndexOf(f7) + ". autó:");
Console.WriteLine(f7.ToString());
Console.WriteLine($"Ára (HUF): {Math.Round(f7.Ar * 248.02)}");

var f8 = autok.Where(x => x.Gyarto.GyartoNev.Equals("Aston Martin") || x.Gyarto.GyartoNev.Equals("Ferrari") || x.Gyarto.GyartoNev.Equals("McLaren") || x.Gyarto.GyartoNev.Equals("Mercedes-Benz") || x.Gyarto.GyartoNev.Equals("Porsche")).ToList();
using StreamWriter sw = new(
    path: "../../../src/forma-1.txt",
    append: false);
foreach (var item in f8) sw.WriteLine($"{item.Azonosito};{item.Gyarto.GyartoNev};{item.Modell};{item.Evjarat};{item.KilometeroraAllas}");