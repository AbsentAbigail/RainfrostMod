using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class Centiwing() : AbstractEnemy(Name, "Centiwing", 6, 2, 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(ApplyCountDownToSelfWhenZapAppliedToEnemies.Name)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}