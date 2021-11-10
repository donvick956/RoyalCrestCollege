using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultSystem
{
    class ExamRecords
    {
        public void Increment()
        {
            string path = @"c:\RoyalCrestCollege\studentrecord.txt";
            int index = 0;
            foreach (var item in File.ReadAllLines(path))
            {

                if (index < 20)
                {
                    var str = item.Split(" -");

                    if (int.Parse(str[1]) >= (int)50)
                    {
                        var newIncrementedValue = int.Parse(str[1]) + 10;
                        var newResult = $"{str[0]} - {newIncrementedValue}";
                        File.AppendAllLines(@"c:\RoyalCrestCollege\newstudentrecord.txt", new String[] { newResult });
                    }
                    else
                    {
                        var newIncrementedValue = int.Parse(str[1]) + 5;
                        var newResult = $"{str[0]} - {newIncrementedValue}";
                        File.AppendAllLines(@"c:\RoyalCrestCollege\newstudentrecord.txt", new String[] { newResult });
                    }
                    index++;
                }
                continue;
                
            }
        }
    }
}
