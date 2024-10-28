﻿using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects;

internal class InstantSummonBoneNeedle() : AbstractStatus<StatusEffectInstantSummon>(Name)
{
    public const string Name = "Instant Summon Bone Needle";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Instant Summon Junk In Hand", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = data as StatusEffectInstantSummon;
                status.targetSummon = AbsentUtils.GetStatusOf<StatusEffectSummon>(SummonBoneNeedle.Name);
            });
    }
}