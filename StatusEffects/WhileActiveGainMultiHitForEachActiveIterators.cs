using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects.Implementations;
using RainfrostMod.StatusEffects.Scriptables;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class WhileActiveGainMultiHitForEachActiveIterators() : AbstractApplyXStatus<StatusEffectWhileActiveXBoostableScriptable>(
        Name, $"While active, gain <x{{a}}><keyword=frenzy> equal to active {Keywords.Iterator.Tag} cards",
        canStack: true,
        canBoost: true,
        effectToApply: "MultiHit",
        applyToFlags: ApplyToFlags.Self,
        subscribe: status =>
        {
            status.scriptableAmount = ScriptableHelper.CreateScriptable<ScriptableTraitsOnBoard>("Iterators On Board", script =>
                {
                    script.allies = true;
                    script.enemies = true;
                    script.trait = Rainfrost.TryGet<TraitData>(Traits.Iterator.Name);
                });
        })
    {
        public const string Name = "While Active Gain MultiHit For Each Active Iterators";
    }
}