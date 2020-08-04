using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using TextFinder.constants;
using TextFinder.models;

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
            List<Error> errorLst = new List<Error>();

            try
            {
                lst.RemoveAll(row => row.Split(" ") == null || row.Split(" ").Length < 3);
                lst.RemoveAll(row => row.Split(" ")[2] != "ERROR");
                lst.RemoveAll(row => new[] {FlowType.HabilitadoresPyme, FlowType.BCICore}.Any(ft => row.Split(" ")[8].Contains(ft)));

                foreach (var item in lst) {
                    var element = item.Split(" ");
                    if (element[8].Equals(FlowType.DataMart)) {
                        Console.WriteLine(element[6]);
                        errorLst.Add(new Error(){
                            Rut = element[6]
                            , FechaHora = DateTime.ParseExact(element[0] + " " + element[1], "yyyy-MM-dd HH:mm:ss,fff", CultureInfo.InvariantCulture)
                            , Method = (element[9] == ErrorType.GenerateSubscription ? MethodType.POST : MethodType.GET)
                            , URL = getSpecificError(element)
                            , TipoError = element[9]
                        });
                    } 
                }

                Console.WriteLine("Total de intentos con error: " + errorLst.Count.ToString());
                Console.WriteLine("Error Subscripciones: " + errorLst.FindAll(e => e.TipoError == ErrorType.GenerateSubscription).Count);
                Console.WriteLine("Error Validaciones: " + errorLst.FindAll(e => e.TipoError == ErrorType.ValidateSubscription).Count);
                Console.WriteLine("Cantidad de ruts únicos consultados: " + errorLst.GroupBy(t => t.Rut).Count());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally {
                errorLst.OrderBy(e => e.FechaHora).ToList().ForEach(Console.WriteLine);
            }
        }

        public static String getSpecificError(String[] element) {
            if (element[9] == ErrorType.ValidateSubscription) {
                if (element[15] == "500")
                    return "Internal Server Error - StatusCode 500";
                else
                    return element[21].Replace("\"", string.Empty).Replace(":", string.Empty);
            }
            else if (element[9] == ErrorType.GenerateSubscription)
                return "https://api.datamart.cl/cte/v1/subscriptions/97006000-6/" + element[6].Replace("[", string.Empty).Replace("]", string.Empty);
            else
                return string.Empty;
        }
    }
}