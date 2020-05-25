using System;
using System.Collections.Generic;

namespace OtherGrammar
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }


    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    class Program
    {
        static List<Item> items = new List<Item>();

        delegate bool ItemSelector(Item item);
        static Item FindItem(ItemSelector selector)
        {
            foreach (var item in items)
            {
                if (selector(item))
                {
                    return item;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            ItemSelector selector = new ItemSelector((Item _item) => { return _item.Rarity == Rarity.Rare; });

            // 무명 함수 / 익명 함수
            Item item = FindItem((Item _item) =>
            {
                return _item.ItemType == ItemType.Weapon;
            });

        }

    }
}
