namespace BlazorMenuComponent.Models;

public class Item
{
    public string Name { get; set; }

    public List<Item> SubItems { get; set; }

    public bool IsExpanded { get; set; }
}