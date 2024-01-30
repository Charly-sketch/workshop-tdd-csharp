using System;

namespace CraftLR.Exercice2;

public class FizzBuzzer
{

    public string Computestring(int i)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (i % 3 == 0)
        {
            return "Fizz";
        }
        else if (i % 5 == 0)
        {
            return "Buzz";
        }

        return i.ToString();
    }

    public string[] ComputeList(int n)
    {
        string[] tab = new string[n];
        for (int i = 1; i <= n; i++)
        {
            tab[i - 1] = Computestring(i);
        }
        return tab;
    }

}
