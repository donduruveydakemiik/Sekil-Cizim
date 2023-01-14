using cizim2.cizim;

namespace cizim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ilk örnek 
            //sekil skl = new sekil();
            //skl.byt.Yukseklik = 12;
            //skl.byt.Genislik = 13;
            //Console.WriteLine(" ");
            //skl.pzyn.X = 5;
            //skl.pzyn.Y = 6;
            //skl.ciz(); ;

            //sekil dksrtgn = new dikdortgen();
            //dksrtgn.byt.Yukseklik = 22;
            //dksrtgn.byt.Genislik = 23;
            //Console.WriteLine(" ");
            //dksrtgn.pzyn.X = 15;
            //dksrtgn.pzyn.Y = 16;
            //dksrtgn.ciz(); ;

            #endregion


            #region ikinci örnek
            // program cs kısmında şekil çiz class oluşturuldu.

            //var ikinci_ornek = new dikdortgen();
            //ikinci_ornek.pzyn.X = 0;
            //ikinci_ornek.pzyn.Y = 1;
            //ikinci_ornek.byt.Yukseklik = 10;
            //ikinci_ornek.byt.Genislik = 20;
            //sekilciz(ikinci_ornek); 
            #endregion


            #region ucuncu örnek

            //var ucuncu_ornek = new elips();
            //ucuncu_ornek.pzyn.X = 0;
            //ucuncu_ornek.pzyn.Y = 1;
            //ucuncu_ornek.byt.Yukseklik = 10; 
            //ucuncu_ornek.byt.Genislik = 20;
            //sekilciz(ucuncu_ornek);
            //ucuncu_ornek.tasi(new pozisyon { X = 100 ,Y=200});
            //sekilciz(ucuncu_ornek);

            #endregion


            #region dorduncu örnek

            //abstract sınıflar somutlaştırılamaz.
            //sınıf veya metod abstract olabilir.
            //yeni sınıflar üretilir ancak nesne üreilemez.
            //override edilmesi zorunludur
            //abstract metod varsa sınıfta abstract olmalıdır. 
            //abstract sınıfta virtual otomatik olarak vardır.

            //sekil s1= new dikdortgen();
            //sekilciz(s1);

            #endregion


            #region besinci örnek
            //sealed bir sınıftan yeni sınıflar türetilmesini önler
            //sealed metod ise override edilemez artık
            // string sınıfı sealed class yapısındadır.



            #endregion


            #region altıncı örnek

            //yapılandırıcı sınıflar 

            //sekil s1 = new dikdortgen();
            //s1.byt.Genislik = 50;
            //s1.byt.Yukseklik = 60;
            //s1.pzyn.X = 1;
            //s1.pzyn.Y = 2;


            #endregion

            #region yedinci örnek

            sekil s1 = new dikdortgen(50, 50, 100, 100);
            sekilciz(s1);
            #endregion
        }


        public static void sekilciz(sekil sekli) =>
            sekli.ciz(); //polymorphism

    }
}