using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class BoneNeedle() : AbstractItem(
        Name, "Bone Needle",
        2, true,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedIncreaseHealthToRandomAlly.Name, 1),
            ];

            card.traits = [
                Rainfrost.TStack("Noomlin"),
            ];
        })
    {
        public const string Name = "BoneNeedle";
    }
}