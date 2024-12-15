using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class RedLizard() : AbstractEnemy(Name, "Red Lizard", 16, 4, 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedTriggerAgainstAllAllies.Name),
            AbsentUtils.SStack(OnKillGainEffects.Name),
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}