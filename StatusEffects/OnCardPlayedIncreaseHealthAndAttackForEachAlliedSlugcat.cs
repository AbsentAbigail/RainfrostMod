using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects.Scriptables;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects
{
    internal class OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat() : AbstractApplyXStatus<StatusEffectApplyXOnCardPlayed>(
        Name, $"Gain <{{a}}><keyword=attack> and <keyword=health> for each allied {Keywords.Slugcat.Tag}",
        true, true,
        "Increase Attack & Health", ApplyToFlags.Self,
        status =>
        {
            status.scriptableAmount = ScriptableHelper.CreateScriptable<ScriptableTraitsOnBoard>("Allied Slugcats", s => {
                s.allies = true;
                s.trait = Rainfrost.TryGet<TraitData>(Traits.Slugcat.Name);
            });
        })
    {
        public const string Name = "On Card Played Increase Health And Attack For Each Allied Slugcat";
    }
}