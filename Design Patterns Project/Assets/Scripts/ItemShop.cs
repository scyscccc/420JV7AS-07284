using UnityEngine;

public abstract class ItemShop : MonoBehaviour
{
    protected abstract Item CreateItem();

    public void Buy()
    {
        Inventory.GetInstance().AddItem(CreateItem());
    }
}
