//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public SpritePathComponent spritePath { get { return (SpritePathComponent)GetComponent(SimComponentsLookup.SpritePath); } }
    public bool hasSpritePath { get { return HasComponent(SimComponentsLookup.SpritePath); } }

    public void AddSpritePath(string newValue) {
        var index = SimComponentsLookup.SpritePath;
        var component = (SpritePathComponent)CreateComponent(index, typeof(SpritePathComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpritePath(string newValue) {
        var index = SimComponentsLookup.SpritePath;
        var component = (SpritePathComponent)CreateComponent(index, typeof(SpritePathComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpritePath() {
        RemoveComponent(SimComponentsLookup.SpritePath);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class SimMatcher {

    static Entitas.IMatcher<SimEntity> _matcherSpritePath;

    public static Entitas.IMatcher<SimEntity> SpritePath {
        get {
            if (_matcherSpritePath == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.SpritePath);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherSpritePath = matcher;
            }

            return _matcherSpritePath;
        }
    }
}
