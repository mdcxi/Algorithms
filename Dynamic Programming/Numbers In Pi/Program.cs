using System;
using System.Collections.Generic;


public class Program {
    public static int NumbersInPi(string pi, string[] numbers) {
        // Write your code here.
        HashSet<string> numbersTable = new HashSet<string>();
        foreach (var number in numbers)
        {
            numbersTable.Add(number);
        }

        Dictionary<int, int> cache = new Dictionary<int, int>();
        int minSpaces = GetMinSpaces(pi, numbersTable, cache, 0);
        return minSpaces == Int32.MaxValue ? -1 : minSpaces;
    }

    public static int GetMinSpaces(string pi, HashSet<string> numbersTable, Dictionary<int, int> cache, int index)
    {
        if (index == pi.Length) return -1;
        if (cache.ContainsKey(index)) return cache[index];
        
        int minSpaces = Int32.MaxValue;

        for (int i = index; i < pi.Length; i++)
        {
            string prefix = pi.Substring(index, i + 1 - index);
            if (numbersTable.Contains(prefix))
            {
                int minSpacesInSuffix = GetMinSpaces(pi, numbersTable, cache, i + 1);
                
                    //Handle int overflow
                    if (minSpacesInSuffix == Int32.MaxValue)
                    {
                        minSpaces = Math.Min(minSpaces, minSpacesInSuffix);
                    }
                    else
                    {
                        minSpaces = Math.Min(minSpaces, minSpacesInSuffix + 1);
                    }
            }
        }

        cache[index] = minSpaces;
        return cache[index];
    }
}