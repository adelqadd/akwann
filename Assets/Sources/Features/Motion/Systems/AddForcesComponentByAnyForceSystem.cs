using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class AddForcesComponentByAnyForceSystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public AddForcesComponentByAnyForceSystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.AnyOf(SimMatcher.GravityForce, SimMatcher.WindForce));
    }

    protected override bool Filter(SimEntity entity) {
        return entity.hasGravityForce || entity.hasWindForce;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            if (!e.hasForces) {
                e.ReplaceForces(new List<Vector2>());
            }
        }
    }
}