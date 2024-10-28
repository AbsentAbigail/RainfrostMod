using AbsentUtilities;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects;

internal class SummonNeuronFly() : AbstractStatus<StatusEffectSummon>(Name)
{
    public const string Name = "Summon Neuron Fly";

    public override StatusEffectDataBuilder Builder()
    {
        return AbsentUtils.StatusCopy("Summon Junk", Name)
            .SubscribeToAfterAllBuildEvent(data =>
            {
                var status = data as StatusEffectSummon;
                status.summonCard = AbsentUtils.GetCard(NeuronFly.Name);
            });
    }
}