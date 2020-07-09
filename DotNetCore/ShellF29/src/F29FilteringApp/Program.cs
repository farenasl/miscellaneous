using System;
using System.IO;
using System.Collections.Generic;
using F29FilteringApp.models;
using F29FilteringApp.helpers;

namespace F29FilteringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<Information> infoLst, filteredList;
            List<Rut> rutLst;

            

            try
            {
                WebBrowser.OpenBrowser("WebTemplates/index.html");
                DateTime startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("../../TestData/25-regs.txt");
                infoLst = Process.readInformationFile("../../TestData/IFIN016202004F29.txt");
                Console.WriteLine("Incoming text file with " + infoLst.Count + " valid rows parsed in " + (DateTime.Now - startTime).TotalSeconds + " seconds");

                startTime = DateTime.Now;
                rutLst = Process.readRutFilteringFile("../../TestData/ruts.txt");
                Console.WriteLine("Incoming excel file with " + rutLst.Count + " valid ruts parsed in " + (DateTime.Now - startTime).TotalSeconds + " seconds");

                startTime = DateTime.Now;
                filteredList = Process.filterInformation(infoLst, rutLst);
                Console.WriteLine("Outcoming text file with " + filteredList.Count + " valid rows parsed in " + (DateTime.Now - startTime).TotalSeconds + " seconds");

                // infoLst.ForEach(Console.WriteLine);
                // rutLst.ForEach(Console.WriteLine);
                //filteredList.ForEach(Console.WriteLine);
                Console.WriteLine("Data rows generated: " + filteredList.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
