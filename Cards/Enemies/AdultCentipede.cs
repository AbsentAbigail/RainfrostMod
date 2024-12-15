using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class AdultCentipede() : AbstractEnemy(Name, "Adult Centipede", 8, 0, 4,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name, 3)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}