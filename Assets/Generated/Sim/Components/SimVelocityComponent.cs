//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public VelocityComponent velocity { get { return (VelocityComponent)GetComponent(SimComponentsLookup.Velocity); } }
    public bool hasVelocity { get { return HasComponent(SimComponentsLookup.Velocity); } }

    public void AddVelocity(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.Velocity;
        var component = (VelocityComponent)CreateComponent(index, typeof(VelocityComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVelocity(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.Velocity;
        var component = (VelocityComponent)CreateComponent(index, typeof(VelocityComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVelocity() {
        RemoveComponent(SimComponentsLookup.Velocity);
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

    static Entitas.IMatcher<SimEntity> _matcherVelocity;

    public static Entitas.IMatcher<SimEntity> Velocity {
        get {
            if (_matcherVelocity == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.Velocity);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherVelocity = matcher;
            }

            return _matcherVelocity;
        }
    }
}