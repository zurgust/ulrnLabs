using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            double[] days = new double[32];
            string[] daysStr = new string[31];
            
            foreach (var n in names)
                if (n.Name == name && n.BirthDate.Day != 1) days[n.BirthDate.Day]++;
            
            for (int i = 0; i < daysStr.Length; i++)
                daysStr[i] = (i+1).ToString();

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                daysStr, 
                days.Skip(1).ToArray());
        }
    }
}

