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
            try
            {
                lst.RemoveAll(row => row.Split(" ") == null || row.Split(" ").Length < 3);
                lst.RemoveAll(row => row.Split(" ")[2] != "ERROR");

                

                Console.WriteLine("Logradas: " + lst.Count.ToString());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally {
                lst.ForEach(Console.WriteLine);
            }
        }
    }
}