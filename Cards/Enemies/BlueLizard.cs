using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Enemies;

public class BlueLizard() : AbstractEnemy(Name, "Blue Lizard", 5, 2, 3,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("On Hit Damage Damaged Target", 4)
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}