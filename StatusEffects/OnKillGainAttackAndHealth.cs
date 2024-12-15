using AbsentUtilities;
using static StatusEffectApplyX;

namespace RainfrostMod.StatusEffects;

internal class OnKillGainAttackAndHealth() : AbstractApplyXStatus<StatusEffectApplyXOnKill>(
    Name, "On kill, gain <+{a}><keyword=health> and <+{a}><keyword=attack>",
    true, true,
    effectToApply: "Increase Attack & Health",
    applyToFlags: ApplyToFlags.Self
)
{
    public const string Name = "On Kill Apply Attack And Health To Self";
}