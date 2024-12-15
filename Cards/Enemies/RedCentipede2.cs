using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class RedCentipede2() : AbstractEnemy(Name, "Red Centipede", 20, 1, 4, CardType.Boss,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name)
        ];
        card.startWithEffects =
        [
            AbsentUtils.SStack("ImmuneToSnow"),
            AbsentUtils.SStack("When Hit Increase Attack Effects To Self")
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}