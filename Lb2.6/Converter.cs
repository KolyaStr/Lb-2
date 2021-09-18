using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._6
{
    class Converter
    {
        private double usd, eur, rub;
        public const double usdRate = 26.7;
        public const double eurRate = 31.45;

        public Converter(double usd, double eur, double rub)
        {
            if (usd > 0)
            {
                this.usd = usd;
                this.eur = eur;
                this.rub = usdRate * usd;
                this.usd = 0;
            }
            if (eur > 0)
            {
                this.usd = usd;
                this.eur = eur;
                this.rub = eurRate * eur;
                this.eur = 0;
            }
            if (rub > 0)
            {
                this.usd = rub / usdRate;
                this.eur = rub / eurRate;
                this.rub = 0;
            }
        }
        public void Print()
        {
            if (usd == 0 && eur == 0)
            {
                Console.WriteLine($"Гривен: {rub}");
            }
            if (rub == 0 && eur > 0)
            {
                Console.WriteLine($"Евро: {eur}");
            }
            if (rub == 0 && usd > 0)
            {
                Console.WriteLine($"Долларов: {usd}");
            }
        }
    }
}
