using System.Linq;

namespace RainfrostMod.StatusEffects.Scriptables
{
    public class ScriptableCardTypeInHand : ScriptableAmount
    {
        public string cardType;
        public int plus;

        public override int Get(Entity entity)
        {
            return References.Player.handContainer.Count(card => card.data.cardType.name == cardType) + plus;
        }
    }
}