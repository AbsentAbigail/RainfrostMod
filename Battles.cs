using AbsentUtilities;
using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;
using RainfrostMod.Cards.Enemies;

namespace RainfrostMod;

public static class Battles
{
    private static WildfrostMod _mod;
    
    public static void AddBattles()
    {
        _mod = AbsentUtils.GetModInfo().Mod;
        
        TheRedCentipede();
    }

    private static void TheRedCentipede()
    {
        new BattleDataEditor(_mod, "Red Centipede")
            .SetSprite("Fight RedCentipede.png")
            .SetNameRef("The Red Centipede")
            .EnemyDictionary(
                ('R', RedCentipede.Name), ('I', InfantCentipede.Name), ('A', AdultCentipede.Name), ('C', Centiwing.Name), ('W', Aquapede.Name)
            ).StartWavePoolData(0, "Wave 1: Red Centipede")
            .ConstructWaves(3, 0, "ICR", "IWR", "IAR")
            .StartWavePoolData(1, "Wave 2: Support Centiwing")
            .ConstructWaves(3, 1, "CI", "CA")
            .StartWavePoolData(2, "Wave 3: Support Aquapede")
            .ConstructWaves(3, 2, "WI", "WA")
            .AddBattleToLoader().LoadBattle(2, exclusivity: BattleStack.Exclusivity.removeAll)
            .GiveMiniBossesCharms([RedCentipede.Name], "CardUpgradeAcorn", "CardUpgradeAttackAndHealth");
    }
}