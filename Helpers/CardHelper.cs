﻿using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using RainfrostMod.Helpers;
using UnityEngine;

namespace RainfrostMod.Cards
{
    internal static class CardHelper
    {
        public static string CardTag(string name)
        {
            return $"<card={Rainfrost.Instance.GUID}.{name}>";
        }

        public static CardDataBuilder DefaultUnitBuilder(
            string name, string title, int? hp = null, int? attack = null, int counter = 0, Pools pools = Pools.General, bool altSprite = false
            )
        {
            string spriteName = altSprite && Rainfrost.Instance.altArt ? "Alt" + name : name;
            return new CardDataBuilder(Rainfrost.Instance)
                .CreateUnit(name, title)
                .SetStats(hp, attack, counter)
                .SetAddressableSprites(spriteName, spriteName + "BG")
                .WithPools(UnitPools(pools));
        }

        public static CardDataBuilder DefaultClunkerBuilder(
            string name, string title, int scrap = 1, int? attack = null, int counter = 0, Pools pools = Pools.General, bool altSprite = false
            )
        {
            string spriteName = altSprite && Rainfrost.Instance.altArt ? "Alt" + name : name;
            return new CardDataBuilder(Rainfrost.Instance)
                .CreateUnit(name, title)
                .WithCardType("Clunker")
                .SetStats(null, attack, counter)
                .SetStartWithEffect(Rainfrost.SStack("Scrap", scrap))
                .SetAddressableSprites(spriteName, spriteName + "BG")
                .WithPools(ItemPools(pools));
        }

        public static CardDataBuilder DefaultItemBuilder(
            string name, string title, int? attack = null, bool needsTarget = false, Pools pools = Pools.General, int shopPrice = 50, bool altSprite = false
            )
        {
            string spriteName = altSprite && Rainfrost.Instance.altArt ? "Alt" + name : name;
            return new CardDataBuilder(Rainfrost.Instance)
                .CreateItem(name, title)
                .SetDamage(attack)
                .NeedsTarget(needsTarget)
                .WithValue(shopPrice)
                .SetAddressableSprites(spriteName, spriteName + "BG")
                .WithPools(ItemPools(pools));
        }

        public static CardDataBuilder DropsBling(this CardDataBuilder builder, int amount)
        {
            return builder.WithValue(amount * 36);
        }

        public static CardDataBuilder SetAddressableSprites(this CardDataBuilder builder, string mainSpriteName, string backgroundSpriteName)
        {
            Sprite mainSprite = Rainfrost.Cards.GetSprite(
                mainSpriteName.Replace(".png", "")
            );
            Sprite backgroundSprite = Rainfrost.Cards.GetSprite(
                backgroundSpriteName.Replace(".png", "")
            );
            return builder.SetSprites(mainSprite, backgroundSprite);
        }

        public static string[] UnitPools(Pools pool)
        {
            string[] pools = [];

            if (pool.HasFlag(Pools.General))
                pools = pools.AddToArray("GeneralUnitPool");

            if (pool.HasFlag(Pools.Snowdweller))
                pools = pools.AddToArray("BasicUnitPool");

            if (pool.HasFlag(Pools.Shademancer))
                pools = pools.AddToArray("MagicUnitPool");

            if (pool.HasFlag(Pools.Clunkmaster))
                pools = pools.AddToArray("ClunkUnitPool");

            return pools;
        }

        public static string[] ItemPools(Pools pool)
        {
            string[] pools = [];

            if (pool.HasFlag(Pools.General))
                pools = pools.AddToArray("GeneralItemPool");

            if (pool.HasFlag(Pools.Snowdweller))
                pools = pools.AddToArray("BasicItemPool");

            if (pool.HasFlag(Pools.Shademancer))
                pools = pools.AddToArray("MagicItemPool");

            if (pool.HasFlag(Pools.Clunkmaster))
                pools = pools.AddToArray("ClunkItemPool");

            return pools;
        }
    }
}