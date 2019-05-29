using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accord.Statistics;
using ZedGraph;
using Accord.Statistics.Models.Regression.Linear;

namespace ExtraTask
{
    public partial class Algorithm
    {
        private static double Maximum(Dictionary<double, double>.ValueCollection valuesList)
        {
            double max = double.MinValue;

            foreach (var digit in valuesList)
                if (digit > max)
                    max = digit;

            return max;
        }

        private static double Minimum(Dictionary<double, double>.ValueCollection valuesList)
        {
            double min = double.MaxValue;

            foreach (var digit in valuesList)
                if (digit < min)
                    min = digit;

            return min;
        }

        public static void InputDataNormalization(ref Dictionary<double, double> variablePair)
        {
            double minDependentValue = Minimum(variablePair.Values);
            double maxDependentValue = Maximum(variablePair.Values);

            var tempDictionary = new Dictionary<double, double>();

            foreach (var pair in variablePair)
            {
                var key = pair.Key;
                var value = (pair.Value - minDependentValue) / (maxDependentValue - minDependentValue);
                tempDictionary.Add(key, value);
            }

            variablePair = tempDictionary;
        }

        public static PointPairList PolynomialRegresion(Dictionary<double, double> variablePair, int degree) // y = DOUBLE_Array[1]*x + DOUBLE_Array[0];
        {
           PolynomialRegression objRegression =
                PolynomialRegression.FromData(degree, variablePair.Keys.ToArray(), variablePair.Values.ToArray());

            //PolynomialLeastSquares objSquares = new PolynomialLeastSquares() { Degree = degree };
            //objSquares.Learn(variablePair.Keys.ToArray(), variablePair.Values.ToArray());

            //Func<double, double> OxOyFunc = x => (objRegression.Weights[0] * x + objRegression.Intercept);

            double[] coefOfFunction = new double[objRegression.Weights.Length + 1];
            coefOfFunction[0] = objRegression.Intercept;

            int index = objRegression.Weights.Length - 1;

            for (int i = 1; i <= objRegression.Weights.Length; i++)
            {
                coefOfFunction[i] = objRegression.Weights[index];
                index--;
            }

            double func(double x)
            {
                double y = 0;
                for (int i = 0; i <= degree; i++)
                    y += coefOfFunction[i] * Math.Pow(x, i);
                return y;
            }

            double[] independentValueArray = new double[variablePair.Count],
                dependentValueArray = new double[variablePair.Count];
            index = 0;

            foreach (var pair in variablePair)
            {
                independentValueArray[index] = pair.Key;
                dependentValueArray[index] = func(pair.Key);
                index++;
            }

            return new PointPairList(independentValueArray, dependentValueArray);
        }

        //public static void PolynomialRegresionMultiVariable(string cID, List<string> inputDataList,
        //    out SortedList<double, double> variablePair, int degree)
        //{

        //}

    }
}