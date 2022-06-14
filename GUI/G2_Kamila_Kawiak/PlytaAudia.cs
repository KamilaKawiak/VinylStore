using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace G2_Kamila_Kawiak
{
    [Serializable]
    public class PlytaAudia 
    { 
        static long licznik;
        string id;
        string wykonawca;
        string tytul;
        DateTime dataWydania;
        double cena;
        public KategoriaMuzyki kategoria;


        public long Licznik { get => licznik; set => licznik = value; }
        public DateTime DataWydania { get => dataWydania; set => dataWydania = value; }
        public double Cena { get => cena; set => cena = value; }
        internal KategoriaMuzyki Kategoria { get => kategoria; set => kategoria = value; }
        public string Tytul { get => tytul; set => tytul = value; }
        public string Wykonawca { get => wykonawca; set => wykonawca = value; }
        public string ID { get => id; set => id = value; }


        public PlytaAudia(long licznik)
        {

            licznik = 1;
        }
        public PlytaAudia() 
        {
            wykonawca = null;
            tytul = null;
            cena = 0;
            dataWydania = DateTime.MinValue;
            id = "KK" + licznik;
        }


        public PlytaAudia(string wykonawca, string tytul, double cena, string dataWydania, KategoriaMuzyki kategoria)
        {
            Wykonawca = wykonawca;
            Tytul = tytul;
            Cena = cena;
            DateTime dataWe = DateTime.MinValue;
            DateTime.TryParseExact(dataWydania, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, DateTimeStyles.None, out dataWe);
            DataWydania = dataWe;
            this.kategoria = kategoria;
        }

        public override string ToString()
        {
            return tytul + " " + wykonawca + " ("+ kategoria + dataWydania.ToShortDateString() + ") "  + " " + cena+ "zł";
        }

        

    }
}


