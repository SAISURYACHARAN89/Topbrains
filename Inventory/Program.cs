using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || input[i] != input[i - 1])
            {
                sb.Append(input[i]);
            }
        }

    
        string temp = sb.ToString().Trim();
        StringBuilder cleaned = new StringBuilder();

        bool space = false;
        foreach (char c in temp)
        {
            if (c == ' ')
            {
                if (!space)
                {
                    cleaned.Append(c);
                    space = true;
                }
            }
            else
            {
                cleaned.Append(c);
                space = false;
            }
        }

        StringBuilder result = new StringBuilder();
        bool newWord = true;

        foreach (char c in cleaned.ToString())
        {
            if (c == ' ')
            {
                result.Append(c);
                newWord = true;
            }
            else
            {
                if (newWord)
                    result.Append(char.ToUpper(c));
                else
                    result.Append(char.ToLower(c));

                newWord = false;
            }
        }

        Console.WriteLine(result.ToString());
    }
}