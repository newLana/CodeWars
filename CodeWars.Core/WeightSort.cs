using System;
using System.Linq;

namespace CodeWars.Core
{
    public class WeightSort
    {
        public static string orderWeight(string strng)
        {
            return string.Join(" ", strng.Split(' ').OrderBy(p => p.Sum(j => Int32.Parse(j.ToString()))).ThenBy(i => i));
        }
    }
}