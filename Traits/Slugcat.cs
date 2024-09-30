using RainfrostMod.StatusEffects;

namespace RainfrostMod.Traits
{
    public class Slugcat() : AbstractTrait(Name, Keywords.Slugcat.Name,
        effects: WhenCardConsumedApplyHealToSelf.Name
        )
    {
        public const string Name = "Slugcat";
    }
}