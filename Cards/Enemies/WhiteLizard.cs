using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.Cards.Enemies;

public class WhiteLizard() : AbstractEnemy(Name, "White Lizard", 5, 1, 2,
    subscribe: card =>
    {
        card.traits =
        [
            AbsentUtils.TStack("Backline"),
            AbsentUtils.TStack("Longshot"),
            AbsentUtils.TStack("Pull"),
        ];
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}