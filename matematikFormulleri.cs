using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mat
{
    public class matematikFormulleri
    {
        public const double pi = 3.14;




        /// <summary>
        /// sayi tek mi?
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>n degeri cift ise false olur</returns>
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }
        /// <summary>
        /// sayı cift mi?
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>n degeri tek ise false olur</returns>
        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Girilen sayinin mutlak değerini vermek
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>Girilen sayinin mutlak değeri</returns>
        public static int mutlakDeger(int n)
        {
            if (n > 0)
                return n;
           
            else if (n<0)           
                return -1 * n;
           
            else  
            return 0;
        }

        /// <summary>
        /// Girilen sayinin asal sayi olup olmadıgini bulmak
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>evet yada hayır</returns>
        public static bool AsalMi(int n)
        {
            
            if (n<=0)
            {
                Console.WriteLine("En küçük asal sayi 2 dir");
                return false;
            }

            bool kontrolEt = true;
            for (int i = 2; i < n; i++)
                if (n%i==0)
                {
                    kontrolEt = false;
                    break;
                }
            return kontrolEt;
        }

        /// <summary>
        /// Girilen sayinin rakamlari toplami kaçtır.
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>Rakamlari Toplami</returns>
        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n=n/10;
            }
            return toplam;
        }

        /// <summary>
        /// 0'dan Girilen sayiya kadar olan sayilan toplamı
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>Toplam</returns>
        public static int NSayisinaKadarOlanSayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 0; i < n; i++)
            {
                toplam += i;
            }
            return toplam;
        }
        /// <summary>
        /// 0'dan Girilen sayiya kadar olan Tek sayilan toplamı
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>Toplam</returns>
        public static int NSayisinaKadarOlanTekSayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 0; i<n; i++)
            {
                if (i%2==1)
                {
                    toplam += i;
                }              
            }
            return toplam;
        }

        /// <summary>
        /// 0'dan Girilen sayiya kadar olan Çift sayilan toplamı
        /// </summary>
        /// <param name="n">Girilen sayi</param>
        /// <returns>Toplam</returns>
        public static int NSayisinaKadarOlanÇiftSayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        /// <summary>
        /// Yarı capı girilen cemberin cevresi
        /// </summary>
        /// <param name="r">Yari Cap</param>
        /// <returns>Cevre</returns>
        public static double CemberinCevresi(double r)
        {
            return 2 * pi * r;
        }
        /// <summary>
        /// Yarı capı girilen Dairenin Alani
        /// </summary>
        /// <param name="r">Yari Cap</param>
        /// <returns>Alan</returns>
        public static double DaireninAlani(double r)
        {
            return  pi * r * r;
        }
       
        /// <summary>
        ///  Yarı capı girilen Daire Diliminin Alani
        /// </summary>
        /// <param name="r">Yari Cap</param>
        /// <param name="aci">acı</param>
        /// <returns>Alan</returns>
        public static double DaireninDilimininAlani(double r,double aci)
        {
            return pi * r * r * (aci / 360);
        }

    }
}
