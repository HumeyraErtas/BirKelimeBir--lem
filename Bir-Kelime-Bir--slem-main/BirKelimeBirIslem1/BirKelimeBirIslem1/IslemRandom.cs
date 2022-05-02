using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirIslem1
{
    public partial class IslemRandom : Form
    {
        public IslemRandom()
        {
            InitializeComponent();
        }

        private void BtnSayilar_Click(object sender, EventArgs e)
        {
            List<Rakamlar> sayilar = new List<Rakamlar>();
            Islemler islem = new Islemler();

            for (int i = 0; i < 6; i++)
            {
                Rakamlar sayi = new Rakamlar();

                if (i != 5)
                {

                    sayi.Deger = islem.SayiIste(1, 10);
                    sayi.Kullanildimi = false;

                }
                else
                {
                    sayi.Deger = islem.SayiIste(10, 100);
                    sayi.Kullanildimi = false;
                }

                sayilar.Add(sayi);
            }
            Islemler.sayiListesi = sayilar;

            Islemler.toplam = 0;
            var result = (from p in sayilar
                          where p.Kullanildimi == false
                          select p).ToList();

            List<Rakamlar> gelenListe;
            int sayac = 0;

            while (result.Count > 0)
            {
                Islemler islem2 = new Islemler();

                if (sayilar.Count == 0)
                {
                    throw new Exception("Liste 0 geliyor.");
                }
                gelenListe = islem2.IkiSayiAl(sayilar);
                if (sayac == 0)
                {

                    string islAdi = islem2.IslemAdiSec();
                    if (islAdi == "-")
                    {

                        while (gelenListe[0].Deger <= gelenListe[1].Deger || gelenListe[0].Deger < 0 || gelenListe[1].Deger < 0)
                        {
                            gelenListe[0].Kullanildimi = false;
                            gelenListe[1].Kullanildimi = false;
                            Islemler.sayac--;
                            gelenListe = islem2.IkiSayiAl(sayilar);

                        }
                    }
                    else if (islAdi == "*")
                    {
                        while (gelenListe[0].Deger < 0 || gelenListe[1].Deger < 0)
                        {
                            gelenListe = islem2.IkiSayiAl(sayilar);
                        }
                    }

                    Islemler.toplam = islem2.IslemYap(gelenListe[0].Deger, gelenListe[1].Deger, islAdi);
                    lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + gelenListe[0].Deger + islAdi + gelenListe[1].Deger + "=" + Islemler.toplam + " - ");
                    string yapilanIslem = islem2.IslemAdi;

                }
                else
                {
                    string islAdi = islem2.IslemAdiSec();
                    if (islAdi == "+")
                     {
                        int temp1 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].Deger, islAdi);
                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp1 + islAdi + gelenListe[0].Deger + "=" + Islemler.toplam + " - ");
                    }
                    else if (islAdi == "-")
                    {
                        if (islAdi == "-")
                        {

                            while (Islemler.toplam <= gelenListe[0].Deger || gelenListe[0].Deger < 0)
                            {
                                int eskiDeger = gelenListe[0].Deger;
                                gelenListe[0].Kullanildimi = false;
                                gelenListe = islem2.IkiSayiAl(sayilar);
                                if (gelenListe[0].Deger == eskiDeger)
                                {
                                    while (islAdi == "-")
                                    {
                                        islAdi = islem2.IslemAdiSec();
                                    }
                                }
                            }
                        }
                        int temp2 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].Deger, islAdi);
                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp2 + islAdi + gelenListe[0].Deger + "=" + Islemler.toplam + " - ");
                    }
                    else if (islAdi == "*")
                    {
                        while (gelenListe[0].Deger < 0)
                        {
                            gelenListe[0].Kullanildimi = false;
                            gelenListe = islem2.IkiSayiAl(sayilar);
                        }

                        int temp3 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].Deger, islAdi);

                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp3 + islAdi + gelenListe[0].Deger + "=" + Islemler.toplam + " - ");
                    }

                }


                sayac++;
                result = (from p in sayilar
                          where p.Kullanildimi == false
                          select p).ToList();
            }

            for (int i = 0; i < sayilar.Count; i++)
            {
                BtnSayi1.Text = sayilar[0].Deger.ToString();
                BtnSayi2.Text = sayilar[1].Deger.ToString();
                BtnSayi3.Text = sayilar[2].Deger.ToString();
                BtnSayi4.Text = sayilar[3].Deger.ToString();
                BtnSayi5.Text = sayilar[4].Deger.ToString();
                BtnSayi6.Text = sayilar[5].Deger.ToString();
                BtnBulunacak.Text = Islemler.toplam.ToString();
            }
 
            if(Islemler.toplam<100 && Islemler.toplam > 1000)
            {
                MessageBox.Show("Tekrar Deneyiniz");
                IslemKismi islemkismi = new IslemKismi();
                islemkismi.Show();
                this.Hide();
            }
            else
            {

                BtnBulunan.Text = Islemler.toplam.ToString();
            }

        }

      
    }
}
