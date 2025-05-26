using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama__Abstraction_1
{
    internal class Program
    {

        // Soyut (abstract) sınıf
        abstract class Hayvan
        {
            public string Ad { get; set; }

            public Hayvan(string ad)
            {
                Ad = ad;
            }

            // Soyut metot – override zorunlu
            public abstract void SesCikar();
        }

        // Interface tanımı
        interface IYuzebilir
        {
            void Yuz();
        }

        // Kalıtım ve interface implementasyonu
        class Balik : Hayvan, IYuzebilir
        {
            public Balik(string ad) : base(ad) { }

            public override void SesCikar()
            {
                Console.WriteLine($"{Ad}: Balık ses çıkarmaz.");
            }

            public void Yuz()
            {
                Console.WriteLine($"{Ad}: Su içinde yüzüyor.");
            }
        }

        static void Main(string[] args)
        {
            Balik balik = new Balik("Nemo");
            balik.SesCikar();
            balik.Yuz();
        }
    }
}
