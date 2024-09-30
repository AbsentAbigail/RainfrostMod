using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion
{
    internal class Saint() : AbstractUnit(
        Name, "Saint",
        health: 2, counter: 2,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnCardPlayedTransformIntoAttunedSaint.Name, 10),
                Rainfrost.SStack("ImmuneToSnow"),
            ];

            card.traits = [
                Rainfrost.TStack(Slugcat.Name),
                Rainfrost.TStack("Fragile")
            ];

            card.greetMessages = ["...? (They stare at you. Maybe they want to join?)"];
        })
    {
        public const string Name = "Saint";
    }
}