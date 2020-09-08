using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class ClearForcesListSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public ClearForcesListSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.Forces);
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            if (e.forces.value != null) {
                List<Vector2> clearedList = e.forces.value;
                clearedList.Clear();
                e.ReplaceForces(clearedList);
            }
        }
    }
}