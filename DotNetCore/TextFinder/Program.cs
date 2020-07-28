using System;
using System.Collections.Generic;
using TextFinder.helpers;

namespace TextFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<String> infoLst = Process.readInformationFile("TestData/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-4vm9s-Longovilo.txt");
            Process.filterInformation(infoLst);

            
        }
    }
}
