using System;

namespace F29FilteringApp
{
    [Serializable]
    public class ValuePair
    {
        private String code;
        public String Code
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