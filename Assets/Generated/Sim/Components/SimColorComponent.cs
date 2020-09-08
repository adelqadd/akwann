//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public ColorComponent color { get { return (ColorComponent)GetComponent(SimComponentsLookup.Color); } }
    public bool hasColor { get { return HasComponent(SimComponentsLookup.Color); } }

    public void AddColor(UnityEngine.Color newValue) {
        var index = SimComponentsLookup.Color;
        var component = (ColorComponent)CreateComponent(index, typeof(ColorComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceColor(UnityEngine.Color newValue) {
        var index = SimComponentsLookup.Color;
        var component = (ColorComponent)CreateComponent(index, typeof(ColorComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveColor() {
        RemoveComponent(SimComponentsLookup.Color);
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

    static Entitas.IMatcher<SimEntity> _matcherColor;

    public static Entitas.IMatcher<SimEntity> Color {
        get {
            if (_matcherColor == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.Color);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherColor = matcher;
            }

            return _matcherColor;
        }
    }
}
