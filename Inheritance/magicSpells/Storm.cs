// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm
  {
    public string Essence
    { get; private set; }
    public bool IsStrong
    { get; private set; }
    public string Caster
    { get; private set; }

    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      Caster = caster;
      IsStrong = isStrong;
    }
    public string Announce()
    {
      string weakness = "";
      if (IsStrong == true){
      weakness = "strong";}
      else {weakness = "weak";}
      return $"{Caster} cast a {weakness} {Essence} storm."; 
    } 
  }
  
}
