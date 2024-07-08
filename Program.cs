using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 25, 43, -20, 65, 1, 9, 15, 25, 65, -86, -4300, 123, 45, 12 };

            #region Dizi içerisindeki sayıların ortalamasını bulunuz. -ÖDEV

            //double ortalama = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    if (i > 0)
            //    {

            //        //ortalama = ortalama + sayilar[i];
            //        ortalama += sayilar[i];


            //    }

            //}
            //ortalama = ortalama / sayilar.Length;
            //Console.WriteLine(ortalama);


            #endregion

            #region Dizi içerisindeki çift sayıların ortalamasını bulunuz. -ÖDEV

            //double ortalama = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ortalama += sayilar[i];
            //    }
            //}
            //ortalama = ortalama / sayilar.Length;
            //Console.WriteLine(ortalama);

            #endregion

            #region Dizi içerisindeki pozitif sayıların adedini yazdırın. -ÖDEV

            //double adet = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 0)
            //    {
            //        adet++;


            //    }

            //}
            //Console.WriteLine(adet);

            #endregion

            #region Dizi içerisindeki en küçük sayıyı bulunuz - ÖDEV

            //int enkucuk = sayilar[0];

            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (enkucuk > sayilar[i])
            //    {
            //        enkucuk = sayilar[i];

            //    }

            //}
            //Console.WriteLine(enkucuk);

            #endregion

            #region Dizi içerisindeki en büyük sayı ile en küçük sayının yerini değiştiriniz - ÖDEV

            //int degiseceksayi = sayilar[0];
            //int degiseceksayi2 = sayilar[0];
            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (degiseceksayi > sayilar[i])
            //    {
            //        degiseceksayi = sayilar[i];

            //    }

            //    if (degiseceksayi2 < sayilar[i])
            //    {
            //        degiseceksayi2 = sayilar[i];
            //    }


            //}
            //Array.Reverse(sayilar);

            //Console.WriteLine("Değişen sayılar = 1) " + degiseceksayi + " 2) " + degiseceksayi2);


            #endregion

            string[] urunler = { "Domates", "Biber", "Soğan", "Yumurta", "Süt  ", "Ekmek", };
            double[] fiyatlar = { 48.5, 63.9, 25, 4.25, 38, 12 };
            string[] birimler = { "KG", "KG", "KG", "AD", "LT", "AD" };
            double[] sepet = new double[6];







            #region Menüyü Listeleyiniz

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ") " + urunler[i] + "\t" + fiyatlar[i] + " TL ");


            //}

            #endregion

            #region Adet sormalı ürün satın aldırma

            //Console.WriteLine("Kaç kalem ürün alacaksın?");
            //int alinacakadet = Convert.ToInt32(Console.ReadLine());
            //double toplam = 0;
            //for (int i = 0; i < alinacakadet; i++)
            //{
            //    Console.WriteLine("Almak istediğiniz ürünün numarasnı giriniz = ");
            //    int urunno = Convert.ToInt32(Console.ReadLine());
            //    int index = urunno - 1;
            //    toplam += fiyatlar[index];
            //}
            //Console.WriteLine("Teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region Başlangıçta adet sormadan ürün satın aldırma - ÖDEV


            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ") " + urunler[i] + "\t" + fiyatlar[i] + " TL ");
            //}

            //double toplam = 0;
            //while (true)
            //{
            //    if (true)
            //    {
            //        Console.WriteLine("Almak istediğiniz ürünleri seçiniz = ");
            //        int urunno = Convert.ToInt32(Console.ReadLine());
            //        int index = urunno - 1;
            //        toplam += fiyatlar[index];
            //    }
            //    Console.WriteLine("Alışverişi bitirmek için 'b', devam etmek için 'd' yazmanız yeterlidir.");
            //    string bitirme = Console.ReadLine();
            //    if (bitirme == "b")
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("MMarketi seçtiğiniz için teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");


            #endregion

            #region Başlangıçta adet sormadan ve her ürün seçildikten bu üründen kaç adet alacaksın. - ÖDEV
            bool islem = true;
            double toplam = 0;
            while (islem)
            {

                Console.WriteLine("****** ÜRÜN FİYAT LİSTESİ ******");
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine((i + 1) + ") " + urunler[i] + "\t " + birimler[i] + "\t" + fiyatlar[i] + " TL ");
                }

                
                //Console.WriteLine("9) Sepetiniz ");
                Console.WriteLine("Almak istediğiniz ürünü giriniz = ");
                int urunno = Convert.ToInt32(Console.ReadLine());
                int index = urunno - 1;
                Console.WriteLine("Ne kadar almak istiyorsunuz = ");
                int adet = Convert.ToInt32(Console.ReadLine());


                if (urunno == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün; " + adet + " KG Domates");
                    sepet[0] += (adet * fiyatlar[0]);

                }
                else if (urunno == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün; " + adet + " KG Biber");
                    sepet[1] += (adet * fiyatlar[1]);
                }
                else if (urunno == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün; " + adet + " KG Soğan");
                    sepet[2] += (adet * fiyatlar[2]);
                }
                else if (urunno == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün; " + adet + " AD Yumurta");
                    sepet[3] += (adet * fiyatlar[3]);
                }
                else if (urunno == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün " + adet + " LT Süt");
                    sepet[4] += (adet * fiyatlar[4]);
                }
                else if (urunno == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Sepete eklenen ürün; " + adet + " AD Ekmek");
                    sepet[5] += (adet * fiyatlar[5]);
                }
                //else if (urunno == 9)
                //{
                //    Console.Clear();
                //    Console.WriteLine("Lütfen fiyat listesindeki ürün numaranızı tekrar kontrol ediniz.");
                //}
                else
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen fiyat listesindeki ürün numaranızı tekrar kontrol ediniz.");
                }
                
                Console.WriteLine("********SEPETİNİZDEKİ ÜRÜNLER*******");
                for (int i = 0; i < fiyatlar.Length; i++)
                {
                    toplam = sepet[i];
                    Console.WriteLine(urunler[i] + "\t \t" + birimler[i] + "\t " + sepet[i]);

                }



                Console.WriteLine("TOPLAM ÖDENECEK TUTAR = \t" + toplam);
                Console.WriteLine("Ödemeye geçmek için '9' devam etmek için '0' yazınız.");
                int islem1 = Convert.ToInt32(Console.ReadLine());
                if (islem1 == 9)
                {

                    islem = false;

                    Console.WriteLine("TOPLAM ÖDENECEK TUTAR = \t" + toplam);
                    Console.WriteLine("MEVO MARKETİ SEÇTİĞİNİZ İÇİN TEŞEKKÜRLER");

                    break;
                }
                else
                {
                    Console.Clear();
                }




            }





            #endregion

        }



    }
}

