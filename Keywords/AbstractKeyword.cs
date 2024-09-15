using Deadpan.Enums.Engine.Components.Modding;
using RainfrostMod.Helpers;

namespace RainfrostMod.Keywords
{
    internal abstract class AbstractKeyword
    {
        private readonly string name;
        private readonly string title;
        private readonly string description;

        public AbstractKeyword(string name, string title, string description)
        {
            this.name = name;
            this.title = title;
            this.description = description;
        }

        public virtual KeywordDataBuilder Builder()
        {
            return KeywordHelper.Keyword(name, title, description);
        }
    }
}