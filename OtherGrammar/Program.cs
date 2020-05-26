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

        //delegate Return MyFunc<T, Return>(T item);
        static Item FindItem(Func<Item, bool> selector)
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

            Func<Item, bool> selector = (Item _item) => { return _item.Rarity == Rarity.Rare; };
            // delegate 를 직접 선언하지 않아도 , 이미 만들어진 애들이 존재한다
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Actional
            // 무명 함수 / 익명 함수
            Item item = FindItem(selector);

        }

    }
}
