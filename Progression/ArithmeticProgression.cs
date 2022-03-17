using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class ArithmeticProgression : Progression
    {
        private double a;
        private double d;
        private int n;
        private bool k;

        public ArithmeticProgression(double a, double d, int n)
        {
            this.a = a;
            this.d = d;
            this.n = n;
        }
        public override void GetElement(double el)
        {
            double an = Math.Round(a + d * (n - 1), 2);
            if (el == an) k = true;
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
