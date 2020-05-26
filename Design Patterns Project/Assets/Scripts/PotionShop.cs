public class PotionShop : ItemShop
{
    protected override Item CreateItem()
    {
        return new Potion();
    }
}
