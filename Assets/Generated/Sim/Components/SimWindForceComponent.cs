//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SimEntity {

    public WindForceComponent windForce { get { return (WindForceComponent)GetComponent(SimComponentsLookup.WindForce); } }
    public bool hasWindForce { get { return HasComponent(SimComponentsLookup.WindForce); } }

    public void AddWindForce(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.WindForce;
        var component = (WindForceComponent)CreateComponent(index, typeof(WindForceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceWindForce(UnityEngine.Vector2 newValue) {
        var index = SimComponentsLookup.WindForce;
        var component = (WindForceComponent)CreateComponent(index, typeof(WindForceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveWindForce() {
        RemoveComponent(SimComponentsLookup.WindForce);
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

    static Entitas.IMatcher<SimEntity> _matcherWindForce;

    public static Entitas.IMatcher<SimEntity> WindForce {
        get {
            if (_matcherWindForce == null) {
                var matcher = (Entitas.Matcher<SimEntity>)Entitas.Matcher<SimEntity>.AllOf(SimComponentsLookup.WindForce);
                matcher.componentNames = SimComponentsLookup.componentNames;
                _matcherWindForce = matcher;
            }

            return _matcherWindForce;
        }
    }
}
