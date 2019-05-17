using System;
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
                readDataList = new List<string>();
                string [] twofolder = timePeriod.Split(' ');
                twofolder[1] = twofolder[1].Substring(0, twofolder[1].Length - 2);
                StreamReader analFileStream = new StreamReader($@"\DataToAnalyze\{twofolder[0]}\{twofolder[1]}\{fileNumber}.csv");
                
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
            
            return null;
        }
    }
}