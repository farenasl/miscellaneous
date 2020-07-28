using System;
using System.Collections.Generic;
using TextFinder.helpers;

namespace TextFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> fileNames = new List<String>();
            fileNames.Add("TestData/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-4vm9s-Longovilo.txt");
            fileNames.Add("TestData/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-kzrfx-Longovilo.txt");
            fileNames.Add("TestData/ms-habilitadorespyme-neg-re-v2-1-849654d895-c485t-Longovilo.txt");
            fileNames.Add("TestData/ms-habilitadorespyme-neg-re-v2-1-849654d895-srpxt-Longovilo.txt");

            List<String> infoLst = Process.readInformationFiles(fileNames);
            Process.filterInformation(infoLst);

            
        }
    }
}
