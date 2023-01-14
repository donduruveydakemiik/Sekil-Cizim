using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cizim2.cizim
{
    public sealed class pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string? ToString() =>
             $": x={X}, y={Y}";

    }
    public sealed class boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public override string? ToString() =>
            $": Genislik= {Genislik}, Yukseklik={Yukseklik}";


    }
    public abstract class sekil
    {
        public sekil()
        {
            Console.WriteLine("base class yapılandırıcı sınıfı çalıştı.");
        }

        public sekil(int yukseklik, int genislik,int x,int y)
        {
            byt = new boyut{ Genislik = genislik, Yukseklik = yukseklik };
            pzyn = new pozisyon { X = x, Y = y };
        }




        public pozisyon pzyn { get; } = new pozisyon();
        public boyut byt { get; } = new boyut();
        public virtual void ciz() =>
            Console.WriteLine($"SEKIL " + $"\nPOZISYON= {pzyn}\nBOYUT=  {byt}");
        public virtual void tasi(pozisyon yenipozisyon)
        {
            pzyn.X = yenipozisyon.X;
            pzyn.Y = yenipozisyon.Y;
            Console.WriteLine($" ŞEKİL TAŞINDI : x=  {pzyn.X}, y= {pzyn.Y}");
        }

        public abstract void yenidenboyutlandir(int genislik, int yukseklik);
        
       


    }
    public class dikdortgen : sekil
    {
        public dikdortgen()
        {
            Console.WriteLine("türetilmiş sınıf çalıştırıldı");
        }

        public dikdortgen(int yukseklik, int genislik, int x, int y) : base(yukseklik, genislik, x, y)
        {
            Console.WriteLine("türetilmiş sınıf 4 parameterli çalıştı ");
        }

        public override void ciz() =>
            Console.WriteLine($"DIKDORGEN: POZISYON={pzyn}, BOYUT={byt}");

        public override void yenidenboyutlandir(int genislik, int yukseklik)
        {
            byt.Yukseklik = yukseklik;
            byt.Genislik= genislik;
            throw new NotImplementedException();
        }
    }
    public class elips : sekil
    {
        public override void tasi(pozisyon yenipozisyon)
        {
            Console.WriteLine("ELİPS TAŞINDI.");
            base.tasi(yenipozisyon);
        }

        public override void yenidenboyutlandir(int genislik, int yukseklik)
        {
            byt.Yukseklik = yukseklik;
            byt.Genislik = genislik;
            throw new NotImplementedException();
        }
    }
    
}
