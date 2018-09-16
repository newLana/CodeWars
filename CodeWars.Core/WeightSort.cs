using System;
using System.Linq;

namespace CSharp
{
    public class WeightSort
    {
        public static string orderWeight(string strng)
        {
            return string.Join(" ", strng.Split(' ').OrderBy(p => p.Select(n => n.ToString()).Sum(j => Convert.ToInt32(j))).ThenBy(i => i));
        }
    }
}