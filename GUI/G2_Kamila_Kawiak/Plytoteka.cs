using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace G2_Kamila_Kawiak
{
    [Serializable]
    public class Plytoteka : Izapisz 
    {
        string nazwa;
        string telefon;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public List<PlytaAudia> plyty;


        public Plytoteka()
        {
            nazwa = null;
            telefon = "000000000";
            plyty = new List<PlytaAudia>();
        }


        public void DodajPlyte(PlytaAudia p)
        {
            plyty.Add(p);
        }

        public Plytoteka(string nazwa, string telefon) : this()
        {
            Nazwa = nazwa;
            Telefon = telefon;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa: " + nazwa);
            sb.AppendLine("Telefon : " + telefon);
            sb.AppendLine(" == Płyty: == ");
            foreach (PlytaAudia p in plyty)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }

        public void ZapiszBin(string nazwa)
        {
            BinaryFormatter bs = new BinaryFormatter();
            FileStream fs = new FileStream(nazwa, FileMode.Create);
            bs.Serialize(fs, this);
            fs.Close();
        }

        public object OdczytajBin(string nazwa)
        {
            object odczytany;
            try
            {
                FileStream fs = new FileStream(nazwa, FileMode.Open);
                BinaryFormatter bs = new BinaryFormatter();
                odczytany = bs.Deserialize(fs);
                fs.Close();
                return odczytany;
            }
            catch (FileNotFoundException)
            {
                //SystemSounds.Exclamation.Play();
                Console.WriteLine($"Plik (nazwa) nie istnieje !!");

            }
            return null;
        }
        

    }
}
