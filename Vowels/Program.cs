using System;
using System.Text;

class Program
{
    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        StringBuilder filtered = new StringBuilder();

     
        foreach (char c in word1)
        {
            char lowerC = char.ToLower(c);

            if (IsVowel(c) || !word2.ToLower().Contains(lowerC))
            {
                filtered.Append(c);
            }
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }
}