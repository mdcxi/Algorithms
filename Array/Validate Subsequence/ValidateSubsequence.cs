using System;
using System.Collections.Concurrent;

class ValidateSubsequence
{
    public static bool CheckValidateSubsequence(List<int> array, List<int> sequence) 
    {
        // Write your code here.
        for (int i = 0, j = 0; i < array.Count; i++)
            if (array[i] == sequence[j])
                if (++j == sequence.Count)
                return true;        
        return false;
    }

    public static void Main()
    {
        List<int> array = new List<int>();
        List<int> sequence = new List<int>();
        
        array.Add(1);
        array.Add(2);
        array.Add(3);
        array.Add(4);
        sequence.Add(2);
        sequence.Add(3);

        bool check = CheckValidateSubsequence(array, sequence);
        if (check)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}