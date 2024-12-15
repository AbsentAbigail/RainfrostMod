using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class InfantCentipede() : AbstractEnemy(Name, "Infant Centipede", 2, 0, 2,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}