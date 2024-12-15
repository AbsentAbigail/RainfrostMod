using AbsentUtilities;
using HarmonyLib;
using RainfrostMod.Cards.Enemies;

namespace RainfrostMod.StatusEffects;

public class RedCentipedePhase2() : AbstractStatus<StatusEffectNextPhase>(
    Name, subscribe: status =>
    {
        status.animation = AbsentUtils.GetStatusOf<StatusEffectNextPhase>("FinalBossPhase2").animation;
        status.nextPhase = AbsentUtils.GetCard(RedCentipede2.Name);
        status.preventDeath = true;
    })
{
    public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
}