using System;
using System.Collections.Generic;
using TextFinder.helpers;

namespace TextFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] filePaths = Process.getFilesInFolder("20200727");
            List<String> infoLst = Process.readInformationFiles(filePaths);
            Process.filterInformation(infoLst);
        }
    }
}
