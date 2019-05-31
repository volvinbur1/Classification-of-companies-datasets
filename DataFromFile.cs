using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ExtraTask
{
    public static class DataFromFile
    {
        //Timestamp [ms];	CPU cores;	CPU capacity provisioned [MHZ];	CPU usage [MHZ];	CPU usage [%];	Memory capacity provisioned [KB];	Memory usage [KB];	Disk read throughput [KB/s];	Disk write throughput [KB/s];	Network received throughput [KB/s];	Network transmitted throughput [KB/s]
        private static readonly Func<string, int> getColomnIdFunc = str =>
        {
            switch (str)
            {
                case "CPU cores":
                    return 1;
                case "CPU capacity provisioned [MHZ]":
                    return 2;
                case "CPU usage [MHZ]":
                    return 3;
                case "CPU usage [%]":
                    return 4;
                case "Memory capacity provisioned [KB]":
                    return 5;
                case "Memory usage [KB]":
                    return 6;
                case "Disk read throughput [KB/s]":
                    return 7;
                case "Disk write throughput [KB/s];":
                    return 8;
                case "Network received throughput [KB/s]":
                    return 9;
                case "Network transmitted throughput [KB/s]":
                    return 10;
            }

            return default(int);
        };

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

        public static Dictionary<double, double> ParseSelectedColumn(string cbText, List<string> listWithInputData)
        {
            long startTime = -1;
            int columnID = getColomnIdFunc(cbText);
            Dictionary<double, double> returnList = new Dictionary<double, double>();

            foreach (var element in listWithInputData)
            {
                string[] arr = element.Split(new[] {";\t"}, StringSplitOptions.RemoveEmptyEntries);
                if (startTime == -1)
                    startTime = Convert.ToInt64(arr[0]);

                double timeStamp = Math.Round((Convert.ToInt64(arr[0]) - startTime)/ 3600.0, 3);
                double independentVar = Math.Round(Convert.ToDouble(arr[columnID]), 3);

                if (!returnList.ContainsKey(timeStamp))
                    returnList.Add(timeStamp, independentVar);
            }

            return returnList;
        }
    }
}