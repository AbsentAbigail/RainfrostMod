using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.Cards.Enemies;

public class PinkLizard() : AbstractEnemy(Name, "Pink Lizard", 7, 4, 4)
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
    public override string FlavourText => "The most basic kind of lizard";
}