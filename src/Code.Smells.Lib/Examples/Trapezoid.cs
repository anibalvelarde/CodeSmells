using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Smells.Lib.Examples
{
    public class Trapezoid
    {
        public Trapezoid(int base1, int base2, int height)
        {
            this.Base1 = base1;
            this.Base2 = base2;
            this.Height = height;
            this.Length = 0;
        }

        public int CalculateVolume(int length = 0)
        {
            this.Length = length;

            return ((this.Base1 + this.Base2) / 2) * this.Height * this.Length;
        }

        public int Base1 { get; private set; }
        public int Base2 { get; private set; }
        public int Height { get; private set; }
        public int Length { get; private set; }
    }
}
