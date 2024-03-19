// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage
  {
    public Archmage(string title) : base(title)
    {

    }
    public override Storm CastRainStorm()
    {
      Storm s = new Storm("rain",false,Title);
      return s;
    }
    public  Storm CastLightningStorm()
    {
      Storm s = new Storm("lightning",true,Title);
      return s;
    }
  }
}
