using System;
using System.Collections.Generic;
using System.IO;
using F29FilteringApp.models;
using System.Linq;

namespace F29FilteringApp.helpers
{
    public class Process
    {
        public static List<ValuePair> getPairList(string[] line)
        {
            var lst = new List<ValuePair>();
            bool specificFormat = int.TryParse(line[2], out _);

            for(int i = 0; i < line.Length; i += 2)
            {
                if (!specificFormat) {
                    lst.Add(new ValuePair(){
                        Code = Convert.ToInt32(line[i])
                        , Value = line[i + 1] + " | " + line[i + 2]
                    });
                    ++i;
                    specificFormat = true;
                }
                else
                    lst.Add(new ValuePair(){
                        Code = Convert.ToInt32(line[i])
                        , Value = line[i + 1]
                    });
            }

            return lst;
        }

        public static Rut setRut(string[] rut) {
            return new Rut() {
                Value = Convert.ToInt64(rut[0])
                , Digit = rut[1]
            };
        }

        public static List<Information> readInformationFile(string filePath) {
            var lst = new List<Information>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    var fullLine = sr.ReadLine();
                    var mainLine = fullLine.Split("|", 5);
                    if(!(mainLine.Length < 4))
                        lst.Add(new Information()
                        {
                            FormType = new FormType()
                            {
                                Acronym = mainLine[0]
                                , Name = "Formulario " + mainLine[0]
                            }
                            , Rut = setRut(mainLine[1].Split('-'))
                            , Period = mainLine[2]
                            , Invoice = Convert.ToInt64(mainLine[3])
                            , ValuePairs = getPairList(mainLine[4].Split("|"))
                        });
                }
            }

            return lst;
        }
 
        public static List<Rut> readRutFilteringFile(string filePath) {
            var lst = new List<Rut>();

            using (StreamReader sr = new StreamReader(filePath))
                while (sr.Peek() >= 0)
                    lst.Add(new Rut()
                    {
                        Value = Convert.ToInt64(sr.ReadLine())
                    });

            return lst;
        }

        public static List<Information> filterInformation(List<Information> infoLst, List<Rut> rutLst) {
            List<Information> result = 
                infoLst.Where(item => rutLst.Any(rut => rut.Value.Equals(item.Rut.Value))).ToList();

            return result;
        }
    }
}