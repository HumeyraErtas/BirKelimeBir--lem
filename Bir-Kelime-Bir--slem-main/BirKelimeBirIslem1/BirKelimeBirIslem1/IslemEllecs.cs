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
    public partial class IslemEllecs : Form
    {
        public IslemEllecs()
        {
            InitializeComponent();
        }

        private void BtnSayilar_Click(object sender, EventArgs e)
        {
            List<Rakamlar> sayilar = new List<Rakamlar>();

            Islemler islem = new Islemler();
            for (int i = 0; i < 6; i++)
            {
                Rakamlar rkm = new Rakamlar();
                rkm.ElleSayi = Convert.ToInt32(txtSayi1.Text);
                rkm.ElleSayi = Convert.ToInt32(txtSayi2.Text);
                rkm.ElleSayi = Convert.ToInt32(txtSayi3.Text);
                rkm.ElleSayi = Convert.ToInt32(txtSayi4.Text);
                rkm.ElleSayi = Convert.ToInt32(txtSayi5.Text);
                rkm.ElleSayi = Convert.ToInt32(txtSayi6.Text);
                sayilar.Add(rkm);
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

                        while (gelenListe[0].ElleSayi <= gelenListe[1].ElleSayi || gelenListe[0].ElleSayi < 0 || gelenListe[1].ElleSayi < 0)
                        {
                            gelenListe[0].Kullanildimi = false;
                            gelenListe[1].Kullanildimi = false;
                            Islemler.sayac--;
                            gelenListe = islem2.IkiSayiAl(sayilar);

                        }
                    }
                    else if (islAdi == "*")
                    {
                        while (gelenListe[0].ElleSayi < 0 || gelenListe[1].ElleSayi < 0)
                        {
                            gelenListe = islem2.IkiSayiAl(sayilar);
                        }
                    }

                    Islemler.toplam = islem2.IslemYap(gelenListe[0].ElleSayi, gelenListe[1].ElleSayi, islAdi);
                    lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + gelenListe[0].ElleSayi + islAdi + gelenListe[1].ElleSayi + "=" + Islemler.toplam + " - ");
                    string yapilanIslem = islem2.IslemAdi;

                }
                else
                {
                    string islAdi = islem2.IslemAdiSec();
                    if (islAdi == "+")
                    {
                        int temp1 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].ElleSayi, islAdi);
                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp1 + islAdi + gelenListe[0].ElleSayi + "=" + Islemler.toplam + " - ");
                    }
                    else if (islAdi == "-")
                    {
                        if (islAdi == "-")
                        {

                            while (Islemler.toplam <= gelenListe[0].ElleSayi || gelenListe[0].ElleSayi < 0)
                            {
                                int eskiDeger = gelenListe[0].ElleSayi;
                                gelenListe[0].Kullanildimi = false;
                                gelenListe = islem2.IkiSayiAl(sayilar);
                                if (gelenListe[0].ElleSayi == eskiDeger)
                                {
                                    while (islAdi == "-")
                                    {
                                        islAdi = islem2.IslemAdiSec();
                                    }
                                }
                            }
                        }
                        int temp2 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].ElleSayi, islAdi);
                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp2 + islAdi + gelenListe[0].ElleSayi + "=" + Islemler.toplam + " - ");
                    }
                    else if (islAdi == "*")
                    {
                        while (gelenListe[0].ElleSayi < 0)
                        {
                            gelenListe[0].Kullanildimi = false;
                            gelenListe = islem2.IkiSayiAl(sayilar);
                        }

                        int temp3 = Islemler.toplam;
                        Islemler.toplam = islem2.IslemYap(Islemler.toplam, gelenListe[0].ElleSayi, islAdi);

                        lstBoxIslem.Items.Add(Islemler.toplamHesapSayaci++ + " . adim icin " + temp3 + islAdi + gelenListe[0].ElleSayi + "=" + Islemler.toplam + " - ");
                    }

                }


                sayac++;
                result = (from p in sayilar
                          where p.Kullanildimi == false
                          select p).ToList();
            }
            BtnBulunacak.Text = Islemler.toplam.ToString();
            for (int i = 0; i < sayilar.Count; i++)
            {
                txtSayi7.Text = Islemler.toplam.ToString();
            }


        }
    }
    }

