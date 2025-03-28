using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    internal class Auto
    {
        public int Azonosito { get; set; }
        public string Evjarat { get; set; }
        public Gyarto Gyarto { get; set; }
        public string Modell { get; set; }
        public int KilometeroraAllas { get; set; }
        public int HengerekSzama { get; set; }
        public Karosszeria Karosszeria { get; set; }
        public Valto Valto { get; set; }
        public string KulsoSzin { get; set; }
        public string BelsoSzin { get; set; }
        public int SzemelyekSzama { get; set; }
        public int Ajtok { get; set; }
        public float FogyasztasVarosban { get; set; }
        public float FogyasztasAutopalyan { get; set; }
        public int Ar { get; set; }

        public override string ToString()
        {
            return $"\tGyártó - modell: {Gyarto.GyartoNev} - {Modell}\n\tFogyasztás: {(FogyasztasVarosban + FogyasztasAutopalyan) / 2}/100km\n\tKilométer óra állása: {KilometeroraAllas} km\n\tVáltó típusa: {Valto.ValtoNev}\n\tÁra (CAD): {Ar}";
        }
        static public List<Auto> LoadFromCsv(string file)
        {
            List<Auto> autok = new();
            using StreamReader sr = new(
                path: $@"../../../src/{file}",
                encoding: Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) autok.Add(new(sr.ReadLine()));
            return autok;
        }
        public Auto(string sor)
        {
            var temp = sor.Split(';');
            Azonosito = int.Parse(temp[0]);
            Evjarat = temp[1];
            Gyarto = new Gyarto(int.Parse(temp[2]), temp[3]);
            Modell = temp[4];
            KilometeroraAllas = int.Parse(temp[5]);
            Karosszeria = new Karosszeria(int.Parse(temp[6]), temp[7]);
            HengerekSzama = int.Parse(temp[8]);
            Valto = new Valto(int.Parse(temp[9]), temp[10]);
            KulsoSzin = temp[11];
            BelsoSzin = temp[12];
            SzemelyekSzama = int.Parse(temp[13]);
            Ajtok = int.Parse(temp[14]);
            FogyasztasVarosban = float.Parse(temp[15]);
            FogyasztasAutopalyan = float.Parse(temp[16]);
            Ar = int.Parse(temp[17]);
        }
    }
}
