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
                DateTime startTime = DateTime.Now;
                infoLst = Process.readInformationFile("../../TestData/25-regs.txt");
                Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + " seconds");

                startTime = DateTime.Now;
                rutLst = Process.readRutFilteringFile("../../TestData/ruts.txt");
                Console.WriteLine("File with " + rutLst.Count + " ruts parsed in " + (DateTime.Now - startTime).TotalSeconds + " seconds");

                startTime = DateTime.Now;
                filteredList = Process.filterInformation(infoLst, rutLst);
                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29_50K_7.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29_50K_1.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29_100K_1.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29_NO_EMPRESAS.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29_EMPRESAS.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

                // startTime = DateTime.Now;
                // infoLst = Process.readInformationFile("TestData/IFIN016202004F29.txt");
                // Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");
            
                // infoLst.ForEach(Console.WriteLine);
                // rutLst.ForEach(Console.WriteLine);
                filteredList.ForEach(Console.WriteLine);
                Console.WriteLine(filteredList.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
