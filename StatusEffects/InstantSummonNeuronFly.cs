using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects
{
    internal class InstantSummonNeuronFly() : AbstractStatus<StatusEffectInstantSummon>(Name)
    {
        public const string Name = "Instant Summon Neuron Fly";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Instant Summon Junk In Hand", Name)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as StatusEffectInstantSummon;
                    status.targetSummon = Rainfrost.GetStatus<StatusEffectSummon>(SummonNeuronFly.Name);
                });
        }
    }
}