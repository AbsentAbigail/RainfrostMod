using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.Cards.Enemies;

public class GreenLizard() : AbstractEnemy(Name, "Green Lizard", 10, 5, 6,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("When Hit Heal Self")
        ];
        card.traits = [
            AbsentUtils.TStack("Frontline")
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}