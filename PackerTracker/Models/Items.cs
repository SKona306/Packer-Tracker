using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string ItemName { get; set; }
    public string Description { get; set; }

    public Item(string itemName, string description)
    {
      ItemName = itemName;
      Description = description;
    }
  }
}