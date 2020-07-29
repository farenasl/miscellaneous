using System;
using System.Collections.Generic;
using TextFinder.helpers;

namespace TextFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> fileNames = set20200727Files();
            

            List<String> infoLst = Process.readInformationFiles(fileNames);
            Process.filterInformation(infoLst);

            
        }

        public static List<String> set20200727Files() {
            List<String> lst = new List<String>();
            lst.Add("20200727/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-4vm9s-Longovilo.txt");
            lst.Add("20200727/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-kzrfx-Longovilo.txt");
            lst.Add("20200727/ms-habilitadorespyme-neg-re-v2-1-849654d895-c485t-Longovilo.txt");
            lst.Add("20200727/ms-habilitadorespyme-neg-re-v2-1-849654d895-srpxt-Longovilo.txt");

            return lst;
        }

        public static List<String> set20200728Files() {
            List<String> lst = new List<String>();
            lst.Add("20200728/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-4vm9s-Longovilo.txt");
            lst.Add("20200728/ms-habilitadorespyme-neg-re-v2-1-557f7d58c6-kzrfx-Longovilo.txt");
            lst.Add("20200728/ms-habilitadorespyme-neg-re-v2-1-849654d895-c485t-Longovilo.txt");
            lst.Add("20200728/ms-habilitadorespyme-neg-re-v2-1-849654d895-srpxt-Longovilo.txt");

            return lst;
        }
    }
}
