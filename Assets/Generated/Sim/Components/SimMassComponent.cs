//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public MassComponent mass { get { return (MassComponent)GetComponent(SimComponentsLookup.Mass); } }
    public bool hasMass { get { return HasComponent(SimComponentsLookup.Mass); } }

    public void AddMass(float newValue) {
        var index = SimComponentsLookup.Mass;
        var component = (MassComponent)CreateComponent(index, typeof(MassComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMass(float newValue) {
        var index = SimComponentsLookup.Mass;
        var component = (MassComponent)CreateComponent(index, typeof(MassComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMass() {
        RemoveComponent(SimComponentsLookup.Mass);
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

    static Entitas.IMatcher<SimEntity> _matcherMass;

    public static Entitas.IMatcher<SimEntity> Mass {
        get {
            if (_matcherMass == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.Mass);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherMass = matcher;
            }

            return _matcherMass;
        }
    }
}