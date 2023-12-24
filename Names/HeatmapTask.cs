using System.Collections.Generic;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(IEnumerable<NameData> names)
        {
            var days = new string[30];
            for (var i = 0; i < days.Length; i++)            
                days[i] = (i + 2).ToString();
            
            var months = new string[12];
            for (var i = 0; i < months.Length; i++)
                months[i] = (i + 1).ToString();

            var colors = new double[days.Length, months.Length];            

            foreach (var name in names)
                if (name.BirthDate.Day != 1)
                    colors[name.BirthDate.Day - 2, name.BirthDate.Month - 1]++;

            return new HeatmapData(                
                "Пример карты интенсивностей",
                colors,
                days,
                months);
        }
    }
}