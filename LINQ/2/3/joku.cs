using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var heroesWithC = heroes.Where(h => h.Contains("c"));
      var lowerHeroesWithC = heroesWithC.Select(h => h.ToLower());
      var sameResult = heroes
        .Where(h => h.Contains("c"))
        .Select(h => h.ToLower());
    }
  }
}
