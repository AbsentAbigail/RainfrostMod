using AbsentUtilities;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects.Implementations;
using RainfrostMod.StatusEffects.Scriptables;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class WhileActiveGainMultiHitForEachActiveIterators()
    : AbstractApplyXStatus<StatusEffectWhileActiveXBoostableScriptable>(
        Name, $"While active, gain <x{{a}}><keyword=frenzy> equal to active {Iterator.Tag} cards",
        canStack: true,
        canBoost: true,
        effectToApply: "MultiHit",
        applyToFlags: ApplyToFlags.Self,
        subscribe: status =>
        {
            status.scriptableAmount = ScriptableHelper.CreateScriptable<ScriptableTraitsOnBoard>("Iterators On Board",
                script =>
                {
                    script.allies = true;
                    script.enemies = true;
                    script.trait = AbsentUtils.GetTrait(Traits.Iterator.Name);
                });
        })
{
    public const string Name = "While Active Gain MultiHit For Each Active Iterators";
}