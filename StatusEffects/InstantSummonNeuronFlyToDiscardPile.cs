using RainfrostMod.StatusEffects.Implementations;

namespace RainfrostMod.StatusEffects
{
    internal class InstantSummonNeuronFlyToDiscardPile() : AbstractStatus<StatusEffectInstantSummonInDeck>(
        Name,
        canStack: true, canBoost: true,
        subscribe: status =>
        {
            status.summonPosition = StatusEffectInstantSummonInDeck.Position.DiscardPile;
            status.targetSummon = Rainfrost.GetStatus<StatusEffectSummon>(SummonNeuronFly.Name);
            status.canSummonMultiple = true;
        })
    {
        public const string Name = "Instant Summon Neuron Fly To Discard Pile";
    }
}