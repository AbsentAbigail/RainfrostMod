using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Items;

namespace RainfrostMod.StatusEffects
{
    internal class SummonFirebugEgg() : AbstractStatus<StatusEffectSummon>(Name)
    {
        public const string Name = "Summon Firebug Egg";

        public override StatusEffectDataBuilder Builder()
        {
            return Rainfrost.StatusCopy("Summon Junk", Name)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    var status = data as StatusEffectSummon;
                    status.summonCard = Rainfrost.TryGet<CardData>(FirebugEgg.Name);
                });
        }
    }
}