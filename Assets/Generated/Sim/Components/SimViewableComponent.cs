//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    static readonly ViewableComponent viewableComponent = new ViewableComponent();

    public bool isViewable {
        get { return HasComponent(SimComponentsLookup.Viewable); }
        set {
            if (value != isViewable) {
                var index = SimComponentsLookup.Viewable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : viewableComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<SimEntity> _matcherViewable;

    public static Entitas.IMatcher<SimEntity> Viewable {
        get {
            if (_matcherViewable == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.Viewable);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherViewable = matcher;
            }

            return _matcherViewable;
        }
    }
}
