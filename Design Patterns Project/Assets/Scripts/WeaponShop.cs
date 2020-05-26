using UnityEngine;

public class WeaponShop : ItemShop
{
    protected override Item CreateItem()
    {
        switch (Random.Range(0, 3))
        {
            default:
            case 0:
                return new Sword();
            case 1:
                return new Axe();
            case 2:
                return new Lance();
        }
    }
}
