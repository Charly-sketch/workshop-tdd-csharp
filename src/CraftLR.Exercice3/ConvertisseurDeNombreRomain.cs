using System;
using System.Collections.Generic;
namespace CraftLR.Exercice3;

public class ConvertisseurDeNombreRomain
{
    private static readonly Dictionary<char, int> SymbolesRomains = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    public int EnNombreArabe(string chiffreRomain)
    {
        if (string.IsNullOrEmpty(chiffreRomain))
            throw new ArgumentException("Le chiffre romain ne peut pas être vide.");

        if (!EstChiffreRomainValide(chiffreRomain))
            throw new ArgumentException("Le chiffre romain n'est pas valide.");

        int total = 0;

        for (int i = 0; i < chiffreRomain.Length; i++)
        {
            int valeurCourante = SymbolesRomains[chiffreRomain[i]];

            if (i + 1 < chiffreRomain.Length && SymbolesRomains[chiffreRomain[i + 1]] > valeurCourante)
                total -= valeurCourante;
            else
                total += valeurCourante;
        }

        return total;
    }

    private bool EstChiffreRomainValide(string chiffreRomain)
    {
        for (int i = 0; i < chiffreRomain.Length; i++)
        {
            if (!SymbolesRomains.ContainsKey(chiffreRomain[i]))
                return false;

            if (i + 1 < chiffreRomain.Length && SymbolesRomains[chiffreRomain[i + 1]] > SymbolesRomains[chiffreRomain[i]])
            {
                if (!EstSousChiffreRomainValide(chiffreRomain.Substring(i, 2)))
                    return false;

                i++;
            }
        }

        return true;
    }

    private bool EstSousChiffreRomainValide(string sousChiffreRomain)
    {
        // Vérifie la validité des sous-chiffres romains qui peuvent être soustraits (IV, IX, XL, XC, CD, CM)
        return sousChiffreRomain switch
        {
            "IV" => true,
            "IX" => true,
            "XL" => true,
            "XC" => true,
            "CD" => true,
            "CM" => true,
            _ => false
        };
    }
}

