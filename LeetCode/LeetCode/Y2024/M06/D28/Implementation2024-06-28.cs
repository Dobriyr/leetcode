namespace LeetCode.Y2024.M06.D28
{
    /// <summary>
    /// 2285. Maximum Total Importance of Roads
    /// </summary>
    public static class Implementation2024_06_28
    {
        public static long MaximumImportance(int n, int[][] roads)
        {
            var cities = roads.SelectMany(x => x).Distinct();

            var citiesWithoutRoads = n - cities.Count();

            int raitingStartCount = 1 + citiesWithoutRoads;

            var cityRoadCounts = cities
                .ToDictionary(city => city, city => roads.Sum(p => p.Count(point => point == city)));

            var citiesAndRoadsCount = cityRoadCounts
                .OrderBy(kvp => kvp.Value)
                .Select((kvp, index) => new { City = kvp.Key, Index = index })
                .ToDictionary(cityWithIndex => cityWithIndex.City, cityWithIndex => cityWithIndex.Index);

            var result = 0;

            for (var i = 0; i < roads.Length; i++)
            {
                result += citiesAndRoadsCount[roads[i][0]] + citiesAndRoadsCount[roads[i][1]] + (raitingStartCount*2);
            }

            return result;
        }

        private static int GetCityImportance(List<CityWithRoads> cityRoads, int[][] roads, int plusIndex, int i, int pos)
        {
            var indexOf = cityRoads.IndexOf(cityRoads.Where(x => x.City == roads[i][0]).FirstOrDefault()!);
            int a = indexOf + plusIndex + 1;
            return a;
        }

        public static int[][] GetFirstInput() => new int[][] { [0, 1], [1, 2], [2, 3], [0, 2], [1, 3], [2, 4] };
        public static int[][] GetSecondInput() => new int[][] { [0, 3], [2, 4], [1, 3] };
        public static int[][] GetThirdInput() => new int[][] { [0, 1] };
    }

    public class  CityWithRoads
    {
        public int City { get; set; }
        public int CountOfRoads { get; set; }
    }
}
