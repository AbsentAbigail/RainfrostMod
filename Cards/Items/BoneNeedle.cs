using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class BoneNeedle() : AbstractItem(
    Name, "Bone Needle",
    2, true,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedIncreaseHealthToRandomAlly.Name)
        ];

        card.traits =
        [
            AbsentUtils.TStack("Noomlin")
        ];
    })
{
    public const string Name = "BoneNeedle";
}