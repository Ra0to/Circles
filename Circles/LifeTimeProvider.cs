using System;
using System.Collections.Generic;
using System.Linq;

namespace Circles
{
    static class LifeTimeProvider
    {
        private static Random _rand = new Random();
        public static int Average = 7;
        public static int Count = 10;
        private static int LeftBound => (int)Math.Floor(0.5f * Average);
        private static int RightBound => (int)Math.Ceiling(1.5f * Average);

        private static int Generate()
        {
            return _rand.Next(LeftBound, RightBound);
        }

        public static List<int> GenerateList()
        {
            var nums = new List<int>();
            var isGood = false;
            
            while (!isGood)
            {
                nums.Clear();
                for (var i = 0; i < Count - 1; i++)
                    nums.Add(Generate());
                var last = Average * Count - nums.Sum();
                if (last > 0)
                {
                    nums.Add(last);
                    isGood = true;
                }
            }

            return nums;
        }
    }
}