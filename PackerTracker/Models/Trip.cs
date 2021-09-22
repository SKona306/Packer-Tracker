using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Trip 
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Trip> _instances = new List<Trip> {};

    public Trip (string name)
    {
      Name = name;
      _instances.Add(this);
    }
  }
}