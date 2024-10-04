using RainfrostMod.Helpers;

namespace RainfrostMod.StatusEffects.TargetModes
{
    internal class TargetModeFullRow : TargetMode
    {
        //public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
        //{
        //    Battle battle = References.Battle;
        //    LogHelper.Log(targetContainer?.name ?? "null");
        //    var rowIndex = battle.GetRowIndex(targetContainer);
        //    var row = battle.GetRow(targetContainer.owner, rowIndex);
        //    CardSlotLane oppositeRow = [];
        //    if (row is CardSlotLane lane)
        //    {
        //        oppositeRow = battle.GetOppositeRow(lane);
        //    }

        //    return [.. row, .. oppositeRow];
        //}

        public override bool TargetRow => true;

        public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            CardSlotLane oppositeLane = [];
            if (targetContainer is CardSlotLane lane)
                oppositeLane = References.Battle.GetOppositeRow(lane);

            return [.. targetContainer, .. oppositeLane];
        }

        public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            return GetPotentialTargets(entity, target, targetContainer);
        }
    }
}