using System;
using System.Linq;

namespace CraftLR.Exercice1;

public class HelloWorld
{
    public static string Hello(string name)
    {
        if (name != null && name.Length != 0) {
            return "Hello, " + name + "!";
        }
        return "Hello, World!";
    }
}