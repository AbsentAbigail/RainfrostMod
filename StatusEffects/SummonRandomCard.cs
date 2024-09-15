using Deadpan.Enums.Engine.Components.Modding;

namespace RainfrostMod.StatusEffects
{
    internal class SummonRandomCard() : AbstractStatus<StatusEffectSummon>(Name)
    {
        public const string Name = "Summon Card";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Summon Junk", Name);
        }
    }
}