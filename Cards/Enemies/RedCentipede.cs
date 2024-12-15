using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class RedCentipede() : AbstractEnemy(Name, "Red Centipede", 20, 4, 8, CardType.Boss,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(RedCentipedePhase2.Name),
            AbsentUtils.SStack(OnCardPlayedGainShellForEnemyZap.Name),
            AbsentUtils.SStack(OnCardPlayedCleanseEnemies.Name)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}