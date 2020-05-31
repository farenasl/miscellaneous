using System;

namespace F29FilteringApp
{
    public class Rut
    {
        private Int64 valor;
        public Int64 Value
        {
            get { return valor; }
            set { valor = value; }
        }
        
        private string digit;
        public string Digit
        {
            get { return digit; }
            set { digit = value; }
        }

        public override string ToString() {
            return Value + (this.digit != null ? "-" + Digit.ToUpper() : string.Empty);
        }
    }
}