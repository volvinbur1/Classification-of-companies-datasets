using System;
using System.Collections.Generic;
using ZedGraph;

namespace ExtraTask
{
    public partial class Algorithm
    {
        //Timestamp [ms];
        //CPU usage [MHz] - influence on total perfomence 66%;  Value that indicate high PC usage - 73%
        //Memory usage [KB] - influence on total perfomence 44%; Value that indicate high PC usage - 89%
        //A - Total PC usage :: high usage 78%
        //B - depends on CPU and Memory usage :: low usage 22%
        //sigma = 1, tetta = 0
        private static List<double[]> GetValueSet(List<string> inputDataList)
        {
            long startTime = -1;
            List<double[]> returnList = new List<double[]>();

            foreach (var element in inputDataList)
            {
                double[] valueSet = new double[3];
                string[] arr = element.Split(new[] { ";\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (startTime == -1)
                    startTime = Convert.ToInt64(arr[0]);

                valueSet[0] = Math.Round((Convert.ToInt64(arr[0]) - startTime) / 3600.0, 3);
                valueSet[1] = Math.Round(Convert.ToDouble(arr[3]), 3);
                valueSet[2] = Math.Round(Convert.ToDouble(arr[6]), 3);

                returnList.Add(valueSet);
            }
            InputDataNormalization(ref returnList);
            return returnList;
        }

        internal static double Maximum(List<double[]> list, int index)
        {
            double max = double.MinValue;

            foreach (var set in list)
            {
                if (set[index] > max)
                    max = set[index];
            }

            return max;
        }

        internal static double Minimum(List<double[]> list, int index)
        {
            double min = double.MaxValue;

            foreach (var set in list)
            {
                if (set[index] < min)
                    min = set[index];
            }

            return min;
        }

        public static void InputDataNormalization(ref List<double[]> variableList)
        {
            double minDependentValue1 = Minimum(variableList, 1);
            double maxDependentValue1 = Maximum(variableList, 1);

            double minDependentValue2 = Minimum(variableList, 2);
            double maxDependentValue2 = Maximum(variableList, 2);

            foreach (var set in variableList)
            {
                set[1] = (set[1] - minDependentValue1) / (maxDependentValue1 - minDependentValue1);
                set[2] = (set[2] - minDependentValue2) / (maxDependentValue2 - minDependentValue2);
            }
        }

        public static Dictionary<double, double> BayesClassifier(List<string> inputDataList)
        {
            List<double[]> valueSet = GetValueSet(inputDataList);
            Dictionary<double, double> classifiedValues = new Dictionary<double, double>();

            double mu = 0, delta = 1;

            double GaussianDistribution(double x) => (1/Math.Sqrt(2*Math.PI*Math.Pow(delta, 2)))*Math.Pow(Math.E, -Math.Pow(x - mu, 2)/(2*Math.Pow(delta,2)));

            foreach (var set in valueSet)
            {
                double time = set[0],
                    posteriorProbability = 0.78 * GaussianDistribution(set[1]) * GaussianDistribution(set[2]);
                classifiedValues.Add(time, posteriorProbability);
            }
           
            return classifiedValues;
        }
    }
}