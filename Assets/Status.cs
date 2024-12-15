using System.Collections.Generic;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Assets;

public static class Status
{
    public static void AddToAssets(List<object> assets)
    {
        assets.AddRange([
            new Zap().Builder(),

            new InstantSummonRandomPearl().Builder(),
            new OnCardPlayedAddRandomPearlToHand().Builder(),
            new SummonRandomCard().Builder(),

            new TemporaryExplode().Builder(),
            new InstantGainExplode().Builder(),

            new SummonBrotherLongLegs().Builder(),
            new TransformIntoDaddyLongLegsOnCardPlayed().Builder(),
            new TransformIntoMotherLongLegsOnCardPlayed().Builder(),

            new OnCardPlayedAddNeuronFlyToHand().Builder(),
            new InstantSummonNeuronFly().Builder(),
            new SummonNeuronFly().Builder(),
            new InstantSummonNeuronFlyToDiscardPile().Builder(),
            new OnCardPlayedSummonNeuronFlyToDiscardPile().Builder(),

            new InstantDoubleZap().Builder(),
            new OnCardPlayedDoubleAllZap().Builder(),

            new OnCardPlayedIncreaseHealthAndAttackForEachAlliedSlugcat().Builder(),

            new OnCardPlayedIncreaseAttackOfAlliesInRow().Builder(),
            new OnCardPlayedReduceAttackOfEnemiesInRow().Builder(),

            new InstantTransformIntoHunterLongLegsPermanent().Builder(),
            new WhenDestroyedTransformSelfIntoHunterLongLegs().Builder(),

            new OnCardPlayedAddBoneNeedleToHand().Builder(),
            new InstantSummonBoneNeedle().Builder(),
            new SummonBoneNeedle().Builder(),
            new OnCardPlayedIncreaseHealthToRandomAlly().Builder(),

            new OnCardPlayedApplySpiceToCardsInHand().Builder(),

            new OnCardPlayedSummonCopyOfLeftmostCardInHand().Builder(),

            new OnOomlinCardPlayedCountDownSelf().Builder(),

            new OnCardPlayedTransformIntoAttunedSaint().Builder(),

            new SummonSingularityBomb().Builder(),
            new InstantSummonSingularityBomb().Builder(),
            new OnCardPlayedAddSingularityBombToHand().Builder(),

            new WhileActiveAddMultiHitToAlliedSlugcats().Builder(),

            new WhileActiveAddMultiHitToAllPearls().Builder(),

            new OnPearlCardPlayedDraw().Builder(),

            new OnCardPlayedCountDownIteratorAllies().Builder(),

            new OnCardPlayedAddExplodeToAllAllies().Builder(),
            new OnCardPlayedIncreaseAttackEffectToSelf().Builder(),

            new WhileActiveGainMultiHitForEachActiveIterators().Builder(),

            new WhenHitAddEggbugEggToHand().Builder(),
            new InstantSummonEggbugEgg().Builder(),
            new SummonEggbugEgg().Builder(),
            new WhenHitAddFirebugEggToHand().Builder(),
            new InstantSummonFirebugEgg().Builder(),
            new SummonFirebugEgg().Builder(),

            new InstantApplyFrenzyToApplier().Builder(),
            new InstantKillAndApplyMultiHitToApplier().Builder(),
            new PreCardPlayedKillItemsInHandAndGainFrenzyForEach().Builder(),

            new OnCardPlayedApplyNullToRandomAlly().Builder(),

            new OnKillGainAttackAndHealth().Builder(),
            new OnCardPlayedTriggerAgainstNonRotAlliesInRow().Builder(),

            new WhenCardConsumedApplyHealToSelf().Builder(),

            new Kill().Builder(),

            new TargetModeFullRow().Builder(),
            
            new RedCentipedePhase2().Builder(),
            new OnCardPlayedGainShellForEnemyZap().Builder(),
            new OnCardPlayedCleanseEnemies().Builder(),
            new GainFrenzyWhenZapAppliedToEnemies().Builder(),
            new ApplyCountDownToSelfWhenZapAppliedToEnemies().Builder(),
        ]);
    }
}