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
    }
}