using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Müşteri adında bir nesne oluşturalım ve oluşturmuş olduğumuz nesnemizin içerisinde static olarak bir ArrayList oluşturalım.
             *Oluşturmuş olduğumuz ArrayList koleksiyonumuzu sanal bir database mantığında kullanacağız.
             *Müşteri sınıfımızın içerisine ;
             *ID,Isim,Soyisim,EmailAdres,KullaniciAdi,Sifre isimleri ile field'lar oluşturalım.
             *Oluşturmuş olduğumuz bu field listesinden bazılarının kapsülleme filtreleri aşağıdaki gibi olmalıdır.
             *Kullanici adı değeri sanal olarak oluşturmuş olduğumuz database imiz içerisinde aranan eğer kullanıcı adı sanal database içerisinde bulunursa field içerisine eklenmek istenen değer eklenemesin.(Kapsülleme)
             *Müşteri ekle adında static metot oluşturalım parametre olarak müşteri tipi alsın içerisinde ;
             *Müşteri nesnesinin null olup olmadığını ve müşteri nesnesi içerisndeki kullanıcı adının dolu olması şartına baksın.
             *Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturuğumuz database mize eklemeden önce email adresinden bir kontrol sağlasın eğere sistemde aynı email adresi ile müşteri değeri var ise eklemesin yok ise sanal database içerisine ilgili nesneyi eklesin.
             */

            Musteri M1 = new Musteri();
            M1.musteriId = 1;
            M1.isim = "Emre";
            M1.soyisim = "Gemici";
            M1.emailAdres = "emre.gemici@hotmail.com";
            M1.kullaniciAdi = "emre.gemici";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri();
            M2.musteriId = 2;
            M2.isim = "Ali";
            M2.soyisim = "Gemici";
            M2.emailAdres = "ali.gemici@hotmail.com";
            M2.kullaniciAdi = "ali.gemici";
            M2.sifre = "2";

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriId = 3;
            M3.isim = "Veli";
            M3.soyisim = "Gemici";
            M3.emailAdres = "veli.gemici@hotmail.com";
            M3.kullaniciAdi = "veli.gemici";
            M3.sifre = "3";

            Musteri.MusteriEkle(M3);

            foreach (Musteri  i in Musteri.musteriDatabase)
            {
                Console.WriteLine(i.musteriId);
                Console.WriteLine(i.isim);
                Console.WriteLine(i.soyisim);
                Console.WriteLine(i.sifre);
                Console.WriteLine(i.emailAdres);
            }
            Console.ReadKey();
        }
    }
}
