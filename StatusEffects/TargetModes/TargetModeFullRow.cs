using System.Collections.Generic;
using AbsentUtilities;
using HarmonyLib;

namespace RainfrostMod.StatusEffects.TargetModes;

internal class TargetModeFullRow : TargetMode
{
    /**
    public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
    {
        LogHelper.Error("Get Potential Targets");
        var entitySet = new HashSet<Entity>();
        if ((bool)target)
        {
            LogHelper.Error(target);
            entitySet.Add(target);
            var rowIndices = Battle.instance.GetRowIndices(entity);
            LogHelper.Error(rowIndices.Join());
            if (rowIndices.Length == 0)
                return entitySet.Count <= 0 ? null : entitySet.ToArray();

            foreach (var rowIndex in rowIndices)
            {
                var row = Battle.instance.GetRow(target.owner, rowIndex);
                if (row is null)
                    continue;
                entitySet.AddRange(row);

                var oppositeRow = Battle.instance.GetRow(Battle.GetOpponent(target.owner), rowIndex);
                if (oppositeRow is null)
                    continue;
                entitySet.AddRange(oppositeRow);
                LogHelper.Error(entitySet.Join());
            }
        }
        else
        {
            LogHelper.Error(entity);
            var rowIndices = Battle.instance.GetRowIndices(entity);
            LogHelper.Error(rowIndices);
            if (rowIndices.Length == 0)
                return entitySet.Count <= 0 ? null : entitySet.ToArray();
            foreach (var rowIndex in rowIndices)
            {
                var row = Battle.instance.GetRow(entity.owner, rowIndex);
                if (row is null)
                    continue;
                entitySet.AddRange(row);

                var oppositeRow = Battle.instance.GetRow(Battle.GetOpponent(entity.owner), rowIndex);
                if (oppositeRow is null)
                    continue;
                entitySet.AddRange(oppositeRow);

                entitySet.Remove(entity);
            }

            LogHelper.Error(entitySet.Join());
            if (entitySet.Count != 0)
                return entitySet.Count <= 0 ? null : entitySet.ToArray();
        }

        return entitySet.Count <= 0 ? null : entitySet.ToArray();
    }
    */
    public override bool TargetRow => true;

    public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
    {
        LogHelper.Error("Get Potential Targets");
        var entitySet = new HashSet<Entity>();
        if ((bool)target)
        {
            LogHelper.Error(target);
            entitySet.Add(target);
            var rowIndices = Battle.instance.GetRowIndices(entity);
            LogHelper.Error(rowIndices.Join());
            if (rowIndices.Length == 0)
                return entitySet.Count <= 0 ? null : entitySet.ToArray();

            foreach (var rowIndex in rowIndices)
            {
                var row = Battle.instance.GetRow(target.owner, rowIndex);
                if (row is null)
                    continue;
                entitySet.AddRange(row);

                var oppositeRow = Battle.instance.GetRow(Battle.GetOpponent(target.owner), rowIndex);
                if (oppositeRow is null)
                    continue;
                entitySet.AddRange(oppositeRow);
                LogHelper.Error(entitySet.Join());
            }
            
            return entitySet.Count <= 0 ? null : entitySet.ToArray();
        }

        if (targetContainer is not null)
        {
            var rowIndex = Battle.instance.GetRowIndex(targetContainer);
            entitySet.AddRange(targetContainer.entities);
            
            var row = Battle.instance.GetRow(entity.owner, rowIndex);
            if (row is not null)
                entitySet.AddRange(row);
            
            var oppositeRow = Battle.instance.GetRow(Battle.GetOpponent(entity.owner), rowIndex);
            if (oppositeRow is not null)
                entitySet.AddRange(oppositeRow);

            entitySet.Remove(entity);
            
            return entitySet.Count <= 0 ? null : entitySet.ToArray();
        }
        
        LogHelper.Error(entity);
        var rowIndices2 = Battle.instance.GetRowIndices(entity);
        LogHelper.Error(rowIndices2);
        if (rowIndices2.Length == 0)
            return entitySet.Count <= 0 ? null : entitySet.ToArray();
        foreach (var rowIndex in rowIndices2)
        {
            var row = Battle.instance.GetRow(entity.owner, rowIndex);
            if (row is null)
                continue;
            entitySet.AddRange(row);

            var oppositeRow = Battle.instance.GetRow(Battle.GetOpponent(entity.owner), rowIndex);
            if (oppositeRow is null)
                continue;
            entitySet.AddRange(oppositeRow);

            entitySet.Remove(entity);
        }

        LogHelper.Error(entitySet.Join());
        if (entitySet.Count != 0)
            return entitySet.Count <= 0 ? null : entitySet.ToArray();
        
        return entitySet.Count <= 0 ? null : entitySet.ToArray();
    }

    public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
    {
        LogHelper.Error("Get Targets");

        return GetPotentialTargets(entity, target, targetContainer);
    }

    public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
    {
        LogHelper.Error("Get Subsequent Targets");
        return GetPotentialTargets(entity, target, targetContainer);
    }
}