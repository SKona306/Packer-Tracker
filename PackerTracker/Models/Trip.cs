using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Trip 
  {
    public string Name { get; set; }
    public List<Item> ItemList {get; set;}
    public int Id { get; }
    private static List<Trip> _instances = new List<Trip> {};

    public Trip (string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      List<Item> ItemList = null;
    }

    public static List<Trip> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}