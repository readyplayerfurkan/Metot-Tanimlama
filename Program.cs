using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ///erisim_belirteci geriDonus_tipi metotAdi(parametre/argüman)
            ///{
            ///komutlar
            ///}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(a, b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            
        }

        static int Topla(int deger1, int deger2)
        {
            int sonuc = deger1 + deger2;
            return sonuc;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string deger1)
        {
            Console.WriteLine(deger1);
        }

        public int ArttirveTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}