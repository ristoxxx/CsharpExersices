// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string title) : base(title)
    {
    }
    public virtual Storm CastRainStorm()
    {
      Storm s = new Storm("rain",false,Title);
      return s;
    }
    

  }
}
