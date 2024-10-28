using System.Linq;

namespace RainfrostMod;

internal class TargetConstraintLeftmostItemInHand : TargetConstraint
{
    public override bool Check(Entity target)
    {
        var hand = References.Player.handContainer.ToList();
        if (hand == null || !hand.Any(e => e.data.cardType.item))
            return not;

        var result = hand.Last(e => e.data.cardType.item) == target;
        return not ? !result : result;
    }
}