using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class Aquapede() : AbstractEnemy(Name, "Aquapede", 8, 1, 5,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(GainFrenzyWhenZapAppliedToEnemies.Name)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}