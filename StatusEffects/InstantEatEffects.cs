using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects;

internal class InstantEatEffects() : AbstractStatus<StatusEffectInstantEatCard>(
    Name, subscribe: card =>
    {
        card.gainAttack = false;
        card.gainHealth = false;
        card.illegalEffects = [AbsentUtils.GetStatus("On Turn Escape To Self")];
    })
{
    public static string Name = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}
