﻿using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using System;

namespace RainfrostMod.Cards.Companion
{
    public abstract class AbstractUnit(
            string name, string title,
            int? health = null, int? attack = null, int counter = 0,
            Pools pools = Pools.General,
            Action<CardData> subscribe = null,
            bool altSprite = false
        ) : AbstractCard(name, title)
    {
        protected readonly int? health = health;
        protected readonly int? attack = attack;
        protected readonly int counter = counter;
        protected readonly Pools pools = pools;
        protected Action<CardData> subscribe = subscribe;

        public virtual CardDataBuilder Builder()
        {
            subscribe ??= delegate { };
            return CardHelper.DefaultUnitBuilder(name, title, health, attack, counter, pools, altSprite)
                .SubscribeToAfterAllBuildEvent(subscribe.Invoke);
        }
    }
}