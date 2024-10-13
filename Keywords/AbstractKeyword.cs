using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal abstract class AbstractKeyword(string name, string title, string description)
    {
        private readonly string name = name;
        private readonly string title = title;
        private readonly string description = description;

        public virtual KeywordDataBuilder Builder()
        {
            return KeywordHelper.Keyword(name, title, description);
        }
    }
}