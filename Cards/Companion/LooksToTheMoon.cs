using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Traits;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class LooksToTheMoon() : AbstractUnit(
            "LooksToTheMoon", "Looks To The Moon",
            attack: 0, counter: 3,
            subscribe: data => {
                data.startWithEffects = [
                    Rainfrost.SStack("Scrap", 2),
                    Rainfrost.SStack(OnCardPlayedAddRandomPearlToHand.Name, 1)
                ];
                data.traits = [
                    Rainfrost.TStack(Iterator.Name)
                ];
            }
        )
    {
    }
}