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
            List<Information> infoLst;

            try
            {
                DateTime startTime = DateTime.Now;
                infoLst = Process.readInformationFile("../TestData/25-regs.txt");
                Console.WriteLine("File with " + infoLst.Count + " rows parsed in " + (DateTime.Now - startTime).TotalSeconds + "seconds");

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
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // infoLst.ForEach(Console.WriteLine);
        }
    }
}
