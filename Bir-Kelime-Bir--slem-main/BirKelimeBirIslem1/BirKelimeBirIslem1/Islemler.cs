using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirKelimeBirIslem1
{
    public class Islemler
    {
        public static int toplamHesapSayaci = 1;
        public static int toplam = 0;
        public static List<Rakamlar> sayiListesi = new List<Rakamlar>();
        public string IslemAdi { get; set; }
        public static readonly Random rnd = new Random();
        public int SayiIste(int kucuk, int buyuk)
        {

            return rnd.Next(kucuk, buyuk);
        }
        public static int sayac = 1;
        public static bool metodaGirdiMi = false;
        public List<Rakamlar> IkiSayiAl(List<Rakamlar> liste)
        {
            if (liste.Count == 0)
            {
                throw new Exception("Count 0");
            }
            List<Rakamlar> donenListe = new List<Rakamlar>();
            liste = liste.Where(x => x.Kullanildimi == false).ToList();

            if (sayac < 2)
            {
                int deger1 = 0, deger2 = 0;
                while (deger1 == deger2)
                {
                    donenListe.Clear();
                    for (int i = 0; i < 2; i++)
                    {

                        if (i == 1)
                        {

                            deger2 = SayiIste(1, liste.Count);
                            Rakamlar o = liste[deger2];
                            o.Kullanildimi = true;
                            donenListe.Add(o);
                        }

                        if (i != 1)
                        {

                            deger1 = SayiIste(1, liste.Count);
                            Rakamlar o = liste[deger1];
                            o.Kullanildimi = true;
                            donenListe.Add(o);
                        }


                    }
                }
            }
            else
            {
                int deger1 = 0;

                donenListe.Clear();

                if (liste.Count == 1)
                {
                    deger1 = 0;
                }
                else
                {
                    deger1 = SayiIste(1, liste.Count);
                }
                Rakamlar o = liste[deger1];
                o.Kullanildimi = true;
                donenListe.Add(o);

            }
            sayac++;
            return donenListe;
        }

        public string IslemAdiSec()
        {
            int value = SayiIste(1, 5);
            switch (value)
            {
                case 1:
                    return "+";

                case 2:
                    return "-";

                case 3:
                    return "*";

                default:
                    return "";


            }
        }
        public int IslemYap(int firstNum, int secondNum, string islAdi)
        {

            if (firstNum < 1 || secondNum < 1)
            {
                throw new Exception("Count 0");
            }
            int result;
            switch (islAdi)
            {
                case "+":
                    IslemAdi = "+";
                    result = firstNum + secondNum;
                    sayac++;
                    metodaGirdiMi = true;
                    return result;

                case "-":
                    IslemAdi = "-";
                    result = firstNum - secondNum;
                    sayac++;
                    metodaGirdiMi = true;
                    if (result < 1)
                    {
                        throw new Exception("toplam(result) 0 ın altında");
                    }
                    return result;

                case "*":
                    IslemAdi = "*";
                    result = firstNum * secondNum;
                    sayac++;
                    metodaGirdiMi = true;
                    if (result < 1)
                    {
                        throw new Exception("toplam(result) 0 ın altında");
                    }
                    return result;

                default:
                    sayac++;
                    metodaGirdiMi = true;
                    return 0;

            }

        }



    }
}
