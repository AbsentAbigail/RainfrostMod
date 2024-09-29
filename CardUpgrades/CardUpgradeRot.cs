using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.CardUpgrades
{
    internal class CardUpgradeRot() : AbstractCardUpgrade(
        Name, "Rot Charm",
        $"Take <1><keyword=health> from all non-{Keywords.Rot.Tag} allies\nGain {Keywords.Rot.Tag}",
        subscribe: charm =>
        {
            charm.effects = [Rainfrost.SStack(OnCardPlayedTakeHealthFromNonRotAllies.Name, 1)];
            charm.giveTraits = [Rainfrost.TStack(Traits.Rot.Name)];
            charm.targetConstraints = [
                TargetConstraintHelper.HasCounterOrReaction(),
                TargetConstraintHelper.HasTrait(Traits.Rot.Name, not: true)
            ];
        })
    {
        public const string Name = "CardUpgradeRot";
    }
}