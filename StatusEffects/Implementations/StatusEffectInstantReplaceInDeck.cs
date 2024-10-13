using RainfrostMod.Helpers;
using System.Collections;

namespace RainfrostMod.StatusEffects.Implementations
{
    internal class StatusEffectInstantReplaceInDeck : StatusEffectInstant
    {
        public CardData replaceWith;

        public override IEnumerator Process()
        {
            LogHelper.Log($"[{target.data.name}] destroyed, transform deck copy into [{replaceWith.name}]");
            Transform();
            yield return base.Process();
        }

        public void Transform()
        {
            Inventory inventory = References.PlayerData.inventory;
            CardData current = target.data;
            CardData transformInto = replaceWith.Clone();

            foreach (CardUpgradeData upgrade in current.upgrades)
            {
                var upgradeCopy = Rainfrost.TryGet<CardUpgradeData>(upgrade.name).Clone();

                if (upgradeCopy.CanAssign(transformInto))
                {
                    upgradeCopy.Assign(transformInto);
                }
                else
                {
                    inventory.upgrades.Add(upgradeCopy);
                }
            }

            if (current.cardType.name == "Leader")
            {
                transformInto.cardType = current.cardType;
                transformInto.SetCustomData("OverrideCardType", "Leader");
            }

            Card card = CardManager.Get(transformInto, null, References.Player, false, true);
            //Checks for renames
            CardData baseCard = Rainfrost.TryGet<CardData>(current.name);
            if (baseCard.title != current.title)
            {
                transformInto.forceTitle = current.title;
                card?.SetName(current.title);
                Events.InvokeRename(card.entity, current.title);
            }

            if (current.cardType.name == "Leader")
            {
                inventory.deck.Insert(0, card.entity.data);
            }
            else
            {
                inventory.deck.Add(card.entity.data);
            }
            inventory.deck.RemoveWhere(card => card.id == current.id);
        }
    }
}