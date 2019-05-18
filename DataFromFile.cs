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

        public static SortedList<double, double> ParseSelectedColumn(int columnID, List<string> listWithInputData)
        {
            SortedList<double, double> returnList = new SortedList<double, double>();
            foreach (var element in listWithInputData)
            {
                string[] arr = element.Split(new[] {";\t"}, StringSplitOptions.RemoveEmptyEntries);
                returnList.Add(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[columnID]));
            }
            return returnList;
        }
    }
}
