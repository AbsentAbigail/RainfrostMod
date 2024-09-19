using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using System;

namespace RainfrostMod.Cards.Items
{
    public abstract class AbstractItem(
            string name, string title,
            int? attack = null, bool needsTarget = false,
            Pools pools = Pools.General,
            int shopPrice = 50,
            bool playOnHand = true,
            Action<CardData> subscribe = null,
            bool altSprite = false
        ) : AbstractCard(name, title)
    {
        public virtual CardDataBuilder Builder()
        {
            subscribe ??= delegate { };
            return CardHelper.DefaultItemBuilder(name, title, attack, needsTarget, pools, shopPrice, altSprite)
                .SubscribeToAfterAllBuildEvent(subscribe.Invoke)
                .CanPlayOnHand(playOnHand);
        }
    }
}