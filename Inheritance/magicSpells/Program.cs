using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm s = new Storm("wind",false,"Zul'rajas");
      Console.WriteLine(s.Announce());
      Pupil p = new Pupil("eero");
      Storm t = p.CastStormWind(); 
      Console.WriteLine(t.Announce());
      Mage m = new Mage("pete");
      Storm u = m.CastRainStorm();   
      Console.WriteLine(u.Announce());
      Archmage a = new Archmage("anssi");
      Storm v = a.CastRainStorm();   
      Console.WriteLine(v.Announce());         
    }
  }
}