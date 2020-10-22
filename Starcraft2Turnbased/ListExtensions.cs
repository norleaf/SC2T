using System;
using System.Collections.Generic;
using System.Linq;

namespace Starcraft2Turnbased
{
    public static class ListExtensions
    {
        public static void AddEach<T>(this List<T> list, params T[] items)
        {
            foreach(var item in items)
            {
                list.Add(item);
            }
        }

        public static void Shuffle<T>(this List<T> list)
        {
            var tempList = new List<T>();
            var random = new Random();
            while(list.Any())
            {
                int i = random.Next(list.Count());
                tempList.Add(list[i]);
                list.RemoveAt(i);
            }

            list = tempList;
        }
    }
}
