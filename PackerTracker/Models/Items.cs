using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public static List<Item> ItemList = new List<Item>  {};

    public List<Item> GetList
    {
      get { return ItemList; }
    } 

    public Item(string name, string description)
    {
      Name = name;
      Description = description;
      ItemList.Add(this);
    }

    public static List<Item> GetAll()
    {
      return ItemList;
    }

    public static void ClearAll()
    {
      ItemList.Clear();
    }
    
  }
}