using AbsentUtilities;
using RainfrostMod.Keywords;
using RainfrostMod.StatusEffects.Implementations;
using RainfrostMod.StatusEffects.Scriptables;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat()
    : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayedBoostableScriptable>(
        Name, $"Gain <+{{a}}><keyword=attack> and <+{{a}}><keyword=health> for each allied {Slugcat.Tag}",
        true, true,
        "Increase Attack & Health", ApplyToFlags.Self,
        status =>
        {
            status.scriptableAmount = ScriptableHelper.CreateScriptable<ScriptableTraitsOnBoard>("Allied Slugcats", s =>
            {
                s.allies = true;
                s.trait = AbsentUtils.GetTrait(Traits.Slugcat.Name);
            });
        })
{
    public const string Name = "On Card Played Increase Health And Attack For Each Allied Slugcat";
}