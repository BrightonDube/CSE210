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
            _top = 1;
            _bottom = 1;
        }
        public Fraction(int wholeNumber){
            _top = wholeNumber;
            _bottom = 1;
        }
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public void SetTop(int top)
        {
            _top = top;
        }
        public int GetTop()
        {
            return _top;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }
        public int GetBottom()
        {
            return _bottom;
        }

        public string GetFractionString(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
            return $"{_top}/{_bottom}";
        }
        public double GetDecimal(double top, int bottom)
        {
            return _top/bottom;
        }
    }
}