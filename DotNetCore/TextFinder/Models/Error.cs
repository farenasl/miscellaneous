using System;

namespace TextFinder.models
{
    public class Error
    {
        private String rut;
        public String Rut
        {
            get { return rut; }
            set { rut = value.Replace("[", String.Empty).Replace("]", String.Empty); }
        }

        public DateTime FechaHora { get; set; }

        public String Method { get; set; }

        public String URL { get; set; }

        public String TipoError { get; set; }
        

        public override String ToString() {
            return FechaHora.ToString("yyyy-MM-dd HH:mm:ss,fff") + " " + TipoError + " " + Rut + " [" + Method + "] " + URL;
        }
        
    }
}