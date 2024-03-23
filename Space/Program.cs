using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		Rover[] rovers = new Rover[] {lunokhod, apollo, sojourner};
      DirectAll(rovers);
      Object[] probes = new Object[] {lunokhod, apollo, sojourner, sputnik};
      IDirectable[] d = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};
      DirectAll(rovers);
      ObserveAll(probes);
      DirectAll(d);
    }
    static void DirectAll(IDirectable[] rovers)
    {
      foreach (IDirectable r in rovers)
      {
        Console.WriteLine(r.GetInfo());
        Console.WriteLine(r.Explore());
        Console.WriteLine(r.Collect());
      }
    }
    static void ObserveAll(Object[] probes)
    {
      foreach (Object probe in probes)
      {
        Console.WriteLine("Tracking a " + probe.GetType());
      }
    }
  }
}
