using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TextFinder.helpers
{
    public class Process
    {
        public static String[] getFilesInFolder(String folderName) {
            return Directory.GetFiles("TestData/" + folderName + "/", "*.txt");
        }

        public static List<String> readInformationFiles(String[] filePaths) {
            var lst = new List<String>();

            foreach (var filePath in filePaths)
                lst.AddRange(readInformationFile(filePath));

            return lst;
        }

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
                            finalLst.Add(element[0] + " " + element[1] + " " + element[6] + " --- ERROR GENERANDO SUBSCRIPCION");
                        else if (element[9].Equals("[verificarSuscripcion]"))
                            finalLst.Add(element[0] + " " + element[1] + " " + element[6] + " --- ERROR VERIFICANDO SUBSCRIPCION");
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
                finalLst.OrderBy(x => x.Split(" --- ")[1]).ToList();
                finalLst.ForEach(Console.WriteLine);
            }
        }
    }
}