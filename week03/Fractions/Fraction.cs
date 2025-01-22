using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 0
            _bottom = 0
        }
        public Fraction(int wholeNumber){
            wholeNumber = wholeNumber;
        }
        public Fraction(int top, int bottom)
        {
            _top = top
            _bottom = bottom
        }

        public void SetTop(int top)
        {
            _top = top;
        }
        public int GetTop()
        {
            return _top;
        }

        
    }
}