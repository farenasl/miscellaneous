using System;
using System.IO;
using System.Collections.Generic;

namespace TextFinder.helpers
{
    public class Process
    {
        public static List<String> readInformationFile(string filePath) {
            var lst = new List<String>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    lst.Add(sr.ReadLine());
                }
            }

            return lst;
        }

        public static void filterInformation(List<String> lst) {
            List<String> finalLst = new List<String>();
            try
            {
                lst.RemoveAll(row => row.Split(" ") == null || row.Split(" ").Length < 3);
                lst.RemoveAll(row => row.Split(" ")[2] != "ERROR");

                foreach (var item in lst)
                {
                    var element = item.Split(" ");
                    if (element[8].Equals("[DataMartClient]")){
                        if (element[9].Equals("[generarSuscripcion]"))
                            finalLst.Add("ERROR GENERANDO SUBSCRIPCION: " + element[6] + " --- " + element[0] + " " + element[1]);
                        else if (element[9].Equals("[verificarSuscripcion]"))
                            finalLst.Add("ERROR VERIFICANDO SUBSCRIPCION: " + element[6] + " --- " + element[0] + " " + element[1]);
                    } 
                }

                Console.WriteLine("Logradas: " + lst.Count.ToString());
                Console.WriteLine("Errores: " + finalLst.Count.ToString());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally {
                finalLst.ForEach(Console.WriteLine);
            }
        }
    }
}