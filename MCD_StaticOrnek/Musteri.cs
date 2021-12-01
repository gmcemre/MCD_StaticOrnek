using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticOrnek
{
    public class Musteri
    {
        #region Sanal Database
        public static ArrayList musteriDatabase;
        #endregion

        #region Static Yapıcı Metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Field
        public int musteriId { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string kullaniciAdi { get; set; }
        public string  sifre { get; set; }

        #endregion

        #region Kapsulleme
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get
            {
                return this._kullaniciAdi;
            }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol )
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        #endregion

        #region Static Metotlar
       static bool musteriKullaniciAdiKontrol(string _kullaniciAdi)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase .Count ; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp .kullaniciAdi ==_kullaniciAdi )
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
        #endregion 

        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Kontrol
            if (M!= null && !string .IsNullOrEmpty (M.kullaniciAdi ) && !string .IsNullOrEmpty (M.emailAdres ))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol )
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı.");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı.");
                }
            }
            #endregion 
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase .Count ; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp .emailAdres ==_emailAdres )
                {
                    Kontrol = true;
                    break;
                }

            }
            return Kontrol;
        }

        
    }
}
