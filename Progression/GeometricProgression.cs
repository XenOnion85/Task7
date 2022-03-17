using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class GeometricProgression : Progression
    {
        private double b;
        private double q;
        private int n;
        private bool k;

        public GeometricProgression(double b, double q, int n)
        {
            this.b = b;
            this.q = q;
            this.n = n;
        }
        public override void GetElement(double ele)
        {
            double bn = Math.Round(b * Math.Pow(q, n - 1), 3);
            if (ele == bn) k = true;
            else k = false;
            return;
        }
        public void Res()
        {
            if (k) Console.WriteLine("Ответ верный");
            else Console.WriteLine("Ответ не верный");
        }
    }
}
