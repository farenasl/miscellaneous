using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using F29FilteringApp;
using F29FilteringApp.helpers;
using System.Collections.Generic;

namespace F29FilteringAppTests
{
    [TestClass]
    public class ProcessTests
    {
        [TestMethod]
        public void getPairList()
        {
            List<ValuePair> expected = new List<ValuePair>();
            expected.Add(new ValuePair(){
                Code = 1
                , Value = "FARMACIAS SALAMANCA LTDA"
            });
            expected.Add(new ValuePair(){
                Code = 3
                , Value = "761376977"
            });
            expected.Add(new ValuePair(){
                Code = 6
                , Value = "BULNES 421"
            });
            expected.Add(new ValuePair(){
                Code = 7
                , Value = "6974183306"
            });
            expected.Add(new ValuePair(){
                Code = 8
                , Value = "SALAMANCA"
            });
            expected.Add(new ValuePair(){
                Code = 15
                , Value = "202004"
            });
            expected.Add(new ValuePair(){
                Code = 62
                , Value = "484646"
            });
            expected.Add(new ValuePair(){
                Code = 89
                , Value = "626298"
            });
            expected.Add(new ValuePair(){
                Code = 91
                , Value = "1127940"
            });
            expected.Add(new ValuePair(){
                Code = 110
                , Value = "4851"
            });
            expected.Add(new ValuePair(){
                Code = 111
                , Value = "4599385"
            });
            expected.Add(new ValuePair(){
                Code = 115
                , Value = "2"
            });
            expected.Add(new ValuePair(){
                Code = 151
                , Value = "16996"
            });
            expected.Add(new ValuePair(){
                Code = 315
                , Value = "20052020"
            });
            expected.Add(new ValuePair(){
                Code = 502
                , Value = "4750"
            });
            expected.Add(new ValuePair(){
                Code = 503
                , Value = "1"
            });
            expected.Add(new ValuePair(){
                Code = 511
                , Value = "3977837"
            });
            expected.Add(new ValuePair(){
                Code = 519
                , Value = "151"
            });
            expected.Add(new ValuePair(){
                Code = 520
                , Value = "4035628"
            });
            expected.Add(new ValuePair(){
                Code = 527
                , Value = "7"
            });
            expected.Add(new ValuePair(){
                Code = 528
                , Value = "57791"
            });
            expected.Add(new ValuePair(){
                Code = 537
                , Value = "3977837"
            });
            expected.Add(new ValuePair(){
                Code = 538
                , Value = "4604135"
            });
            expected.Add(new ValuePair(){
                Code = 547
                , Value = "1127940"
            });
            expected.Add(new ValuePair(){
                Code = 562
                , Value = "3182"
            });
            expected.Add(new ValuePair(){
                Code = 563
                , Value = "24232289"
            });
            expected.Add(new ValuePair(){
                Code = 584
                , Value = "3"
            });
            expected.Add(new ValuePair(){
                Code = 595
                , Value = "1127940"
            });

            string row = "F29|76137697-7|202004|6974183306|1|FARMACIAS SALAMANCA LTDA|3|761376977|6|BULNES 421|7|6974183306|8|SALAMANCA|15|202004|62|484646|89|626298|91|1127940|110|4851|111|4599385|115|2|151|16996|315|20052020|502|4750|503|1|511|3977837|519|151|520|4035628|527|7|528|57791|537|3977837|538|4604135|547|1127940|562|3182|563|24232289|584|3|595|1127940";
            string[] line = row.Split("|", 5)[4].Split("|");
            List<ValuePair> actual = Process.getPairList(line);

            Console.WriteLine(actual);
            Console.WriteLine(expected);

            Assert.AreEqual(String.Join(String.Empty, expected), String.Join(String.Empty, actual));
        }
    }
}