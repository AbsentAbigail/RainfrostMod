using AbsentUtilities;
using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Cards.Companion;
using RainfrostMod.Cards.Enemies;
using System;

namespace RainfrostMod;

public static class Battles
{
    private static WildfrostMod _mod;
    
    public static void AddBattles()
    {
        _mod = AbsentUtils.GetModInfo().Mod;
        
        TheRedCentipede();
        TheLizardLot();
    }

    private static void TheLizardLot()
    {
        new BattleDataEditor(_mod, "Lizard Lot")
            .SetSprite("Fight LizardLot.png")
            .SetNameRef("The Lizard Lot")
            .EnemyDictionary(
                ('R', RedLizard.Name), ('B', BlueLizard.Name), ('G', GreenLizard.Name), ('P', PinkLizard.Name), ('W', WhiteLizard.Name)
            ).StartWavePoolData(0, "Wave 1")
            .ConstructWaves(3, 0, "GB", "GP")
            .StartWavePoolData(1, "Wave 2")
            .ConstructWaves(3, 1, "PWP", "PBW", "BBW")
            .StartWavePoolData(2, "Wave 3")
            .ConstructWaves(3, 2, "GR")
            .AddBattleToLoader().LoadBattle(1, exclusivity: BattleStack.Exclusivity.removeAll)
            .GiveMiniBossesCharms([RedLizard.Name], "CardUpgradeBlock", "CardUpgradeBombskull");
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