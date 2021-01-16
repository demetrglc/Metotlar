using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //classtan tanımlamak istediğimizden
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
          

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //'in urunler' dediğimizde benim ürünler diye dizi varya onu tek tek gez demek
                                           //urun urun sayımız kadar donmeyi söyler. O ank i elemana takma isim veriyoruz ne dersek artık.
                                           //Urun calışacagı veri tipini yazıyoruz. varda yazsak olur. var ise aynı şeyi ifade eder.
            { 
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            


            }
            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil elma", 18);
            sepetManager.Ekle2("karpuz", "yeşil karpuz", 62); //Bunu class olmadan yaptık. Peki neden class yapmalıyız?
            //Çünkü şimdi birde stok sayısı verilmesi istendiğinde int stokadedi tanımlarsın manager da . Sonra buraya gelip hepsine tek tek yazmamız lağzım

            //Buna encapsilation denir. Gittim class şekilde yazdım ve diğer sayfalar elimde patlamadı .
            

        }
    }
}
