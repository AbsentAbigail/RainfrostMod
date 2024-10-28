namespace RainfrostMod;

internal class CardScriptRemoveHealthIcon : CardScript
{
    public override void Run(CardData target)
    {
        target.hasHealth = false;
    }
}