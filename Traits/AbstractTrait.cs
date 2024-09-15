using Deadpan.Enums.Engine.Components.Modding;
using System.Linq;

namespace RainfrostMod.Traits
{
    public abstract class AbstractTrait(string name, string keyword = null, params string[] effects)
    {
        protected readonly string name = name;
        protected readonly string keyword = keyword;
        protected readonly string[] effects = effects;

        public virtual TraitDataBuilder Builder()
        {
            return new TraitDataBuilder(Rainfrost.Instance)
                .Create(name)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    data.effects = effects.ToList().Select(Rainfrost.GetStatus<StatusEffectData>).ToArray();
                    data.keyword = keyword != null ? Rainfrost.TryGet<KeywordData>(keyword) : null;
                });
        }
    }
}