using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class AddGravityForceSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public AddGravityForceSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.GravityForce, SimMatcher.Forces));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            List<Vector2> forces = e.forces.value;
            forces.Add(e.gravityForce.value);
            e.ReplaceForces(forces);
        }
    }
}