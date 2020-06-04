using System;

namespace F29FilteringApp
{
    public class ValuePair
    {
        private Int32 code;
        public Int32 Code
        {
            get { return code; }
            set { code = value; }
        }
        private String val;
        public String Value
        {
            get { return val; }
            set { val = value; }
        }
        
        public override string ToString() {
            return "|" + Code + "|" + Value;
        }
    }
}