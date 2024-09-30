using RainfrostMod.StatusEffects;

namespace RainfrostMod.Traits
{
    public class Rot() : AbstractTrait(Name, Keywords.Rot.Name, 
        effects: OnCardPlayedTriggerAgainstNonRotAlliesInRow.Name
        )
    {
        public const string Name = "Rot";
    }
}