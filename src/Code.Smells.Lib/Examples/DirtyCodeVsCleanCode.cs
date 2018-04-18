using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Smells.Lib.Examples
{
    public class DirtyCodeVsCleanCode
    {
        public string DirtyCodeExample()
        {
            int delta = 0;

            /////////////////////////////////////////
            // Lots of comment in this code telling 
            // everything about almost every 
            int a = 10;

            // sinlge
            int b = 20;

            // line
            int l = 3;

            // of...
            int h = 4;

            // code....
            var V = ((a + b) / 2) * h * l;

            // even if it is the simplest of cases
            if (V != 0 && (a + b) > 40 && (DateTime.UtcNow.Millisecond % 2 == 0))
            {
                delta = 100;
            }
            else
            {
                delta = -100;
            }

            // the result
            var r = V + delta;

            if (r > 0 && (DateTime.UtcNow.Day % 2 != 0))
            {
                return $"It worked!... and V = {V} :)";
            }
            else
            {
                return "It did not work  :(";
            }
            /////////////////////////////////////////

        }

        public string CleanCodeExample()
        {
            var trapezoid = MakeATrapezoid(base1: 10, base2: 20, height: 4);

            var TrapezoidVolume = trapezoid.CalculateVolume(length: 4);

            var PaddedTrapezoidVolume = ComputeVolumetricPadding(trapezoid, TrapezoidVolume);

            return ProduceTrapezoidalMessage(PaddedTrapezoidVolume);
        }

        #region CleanCodeChapters

        private Trapezoid MakeATrapezoid(int base1, int base2, int height)
        {
            return new Trapezoid(base1, base2, height);
        }

        private int ComputeVolumetricPadding(Trapezoid trapezoid, int TrapezoidVolume)
        {
            if (TheFirstMagicalNumberIsCalculatedCorrectly(trapezoid))
            {
                TrapezoidVolume += MAGIC_NUMBER_TO_ADD_OR_SUBTRACT;
            }
            else
            {
                TrapezoidVolume -= MAGIC_NUMBER_TO_ADD_OR_SUBTRACT;
            }

            return TrapezoidVolume;
        }

        private string ProduceTrapezoidalMessage(int paddedTrapezoidVolume)
        {
            if (TheSecondMagicalNumberIsCalculatedCorrectly(paddedTrapezoidVolume))
            {
                return $"It worked!... and V = {paddedTrapezoidVolume} :)";
            }
            else
            {
                return "It did not work  :(";
            }
        }

        #region CleanCodeSubChapters

        private bool TheSecondMagicalNumberIsCalculatedCorrectly(int paddedTrapezoidVolume)
        {
            return paddedTrapezoidVolume > 0 && (DateTime.UtcNow.Day % 2 != 0);
        }

        private bool TheFirstMagicalNumberIsCalculatedCorrectly(Trapezoid t)
        {
            return (t.CalculateVolume() != 0 && (t.Base1 + t.Base2) > 40 && (DateTime.UtcNow.Millisecond % 2 == 0));
        }

        #region CleanCodeGlossary

        private const int MAGIC_NUMBER_TO_ADD_OR_SUBTRACT = 100;

        #endregion

        #endregion

        #endregion
    }
}
