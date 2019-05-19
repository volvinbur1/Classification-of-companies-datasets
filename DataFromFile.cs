using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ExtraTask
{
    public class DataFromFile
    {
        public static bool ReadFromFile(string timePeriod, string fileNumber, out List<string> readDataList)
        {
            try
            {
                string line;
                readDataList = new List<string>();
                string [] twofolder = timePeriod.Split(' ');
                twofolder[0] = twofolder[0].Substring(1, twofolder[0].Length - 2);
                StreamReader analFileStream = new StreamReader($@"DataToAnalyze\{twofolder[0]}\{twofolder[1]}\{fileNumber}.csv");
                while (( line = analFileStream.ReadLine()) != null)
                {
                    readDataList.Add(line);
                }

                readDataList.RemoveAt(0);

                return true;

            }
            catch (Exception)
            {
                readDataList = null;
                return false;
            }
        }

        public static SortedList<double, double> ParseSelectedColumn(int columnID, List<string> listWithInputData)//, out double minValueOfIndependentVar, out double maxValueOfIndependentVar)
        {
            long startTime = -1;
            //minValueOfIndependentVar = double.MaxValue;
            //maxValueOfIndependentVar = double.MinValue;
            SortedList<double, double> returnList = new SortedList<double, double>();

            foreach (var element in listWithInputData)
            {
                string[] arr = element.Split(new[] {";\t"}, StringSplitOptions.RemoveEmptyEntries);
                if (startTime == -1)
                    startTime = Convert.ToInt64(arr[0]);

                double timeStamp = Math.Round((Convert.ToInt64(arr[0]) - startTime)/ 3600.0, 3);
                double independentVar = Convert.ToDouble(arr[columnID]);

                //if (independentVar > maxValueOfIndependentVar)
                //    maxValueOfIndependentVar = independentVar;
                //if (independentVar < minValueOfIndependentVar)
                //    minValueOfIndependentVar = independentVar;

                if (!returnList.ContainsKey(timeStamp))
                    returnList.Add(timeStamp, independentVar);
            }

            return returnList;
        }
    }
}