using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class UpdateAccelerationByAccumulatedForceSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public UpdateAccelerationByAccumulatedForceSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Acceleration, SimMatcher.Forces));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            e.ReplaceAcceleration(new Vector2(e.accumulatedForce.value.x * Time.deltaTime, e.accumulatedForce.value.y * Time.deltaTime));
        }
    }
}