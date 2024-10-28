using AbsentUtilities;
using RainfrostMod.Keywords;

namespace RainfrostMod.StatusEffects;

internal class TargetModeFullRow() : AbstractStatus<StatusEffectChangeTargetMode>(
    Name,
    subscribe: status =>
    {
        status.targetMode = ScriptableHelper.CreateScriptable<TargetModes.TargetModeFullRow>("Target Mode FullRow");
    })
{
    public const string Name = "Target Mode FullRow";
}