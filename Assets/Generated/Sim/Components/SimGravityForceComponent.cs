//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public GravityForceComponent gravityForce { get { return (GravityForceComponent)GetComponent(SimComponentsLookup.GravityForce); } }
    public bool hasGravityForce { get { return HasComponent(SimComponentsLookup.GravityForce); } }

    public void AddGravityForce(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.GravityForce;
        var component = (GravityForceComponent)CreateComponent(index, typeof(GravityForceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGravityForce(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.GravityForce;
        var component = (GravityForceComponent)CreateComponent(index, typeof(GravityForceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGravityForce() {
        RemoveComponent(SimComponentsLookup.GravityForce);
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

    static Entitas.IMatcher<SimEntity> _matcherGravityForce;

    public static Entitas.IMatcher<SimEntity> GravityForce {
        get {
            if (_matcherGravityForce == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.GravityForce);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherGravityForce = matcher;
            }

            return _matcherGravityForce;
        }
    }
}