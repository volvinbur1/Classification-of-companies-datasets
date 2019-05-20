﻿using System;
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
        //Timestamp [ms];	CPU cores;	CPU capacity provisioned [MHZ];	CPU usage [MHZ];	CPU usage [%];	Memory capacity provisioned [KB];	Memory usage [KB];	Disk read throughput [KB/s];	Disk write throughput [KB/s];	Network received throughput [KB/s];	Network transmitted throughput [KB/s]
        private static Func<string, int> getColomnIdFunc = str =>
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

        public static PointPairList PolynomialRegresion(string cID, List<string> inputDataList, out SortedList<double, double> variableList, int degree) // y = DOUBLE_Array[1]*x + DOUBLE_Array[0];
        {
            int columnID = getColomnIdFunc(cID);

            variableList = DataFromFile.ParseSelectedColumn(columnID, inputDataList);

            PolynomialLeastSquares objSquares = new PolynomialLeastSquares() { Degree = degree };
            PolynomialRegression objRegression =
                objSquares.Learn(variableList.Keys.ToArray(), variableList.Values.ToArray());

            //Func<double, double> OxOyFunc = x => (objRegression.Weights[0] * x + objRegression.Intercept);

            double[] coefOfFunction = new double[objRegression.Weights.Length + 1];
            coefOfFunction[0] = Math.Round(objRegression.Intercept, 1);

            for (int i = 1; i <= objRegression.Weights.Length; i++)
                coefOfFunction[i] = Math.Round(objRegression.Weights[i - 1], 1);
            
            double func(double x)
            {
                double y = 0;
                for (int i = 0; i <= degree; i++)
                    y += coefOfFunction[i] * Math.Pow(x, i);
                return y;
            }

            double[] independentValueArray = new double[variableList.Count], dependentValueArray = new double[variableList.Count];
            int index = 0;

            foreach (var pair in variableList)
            {
                independentValueArray[index] = pair.Key;
                dependentValueArray[index] = func(pair.Value);
                index++;
            }

            return new PointPairList(independentValueArray, dependentValueArray);
        }
    }
}