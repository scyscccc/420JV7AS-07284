public class Item
{
    public string Name => GetType().Name;
}

public class Potion : Item { }

public class Sword : Item { }

public class Axe : Item { }

public class Lance : Item { }
