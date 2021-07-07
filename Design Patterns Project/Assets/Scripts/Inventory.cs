using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    static Inventory instance;
    List<Item> items = new List<Item>();

    private Inventory() { }

    public static Inventory GetInstance()
    {
        if (instance == null)
        {
            instance = new Inventory();
        }

        return instance;
    }

    public void AddItem(Item item) => items.Add(item);

    public string GetItemNames()
    {
        return string.Join("\n", items.Select(x => x.Name));
    }
}
