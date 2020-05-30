using System.Linq;
using System.Collections.Generic;
using System;

namespace ShellF29FilteringApp.models
{
    public class Information
    {
        public FormType FormType { get; set; }
        public String Rut { get; set; }
        public String Period { get; set; }
        public Int64 Invoice { get; set; }
        public List<ValuePair> ValuePairs { get; set; }

        public override string ToString() {
            return FormType.Acronym + "|" + Rut + "|" + Period + "|" + Invoice + String.Join(String.Empty, ValuePairs);
        }
    }
}