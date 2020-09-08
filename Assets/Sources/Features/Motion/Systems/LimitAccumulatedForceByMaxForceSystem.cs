using Entitas;
using UnityEngine;

public sealed class LimitAccumulatedForceByMaxForceSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public LimitAccumulatedForceByMaxForceSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.AccumulatedForce, SimMatcher.MaxForce));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            if (e.accumulatedForce.value.magnitude >= e.maxForce.value) {
                Vector2 normalizedForce = e.accumulatedForce.value.normalized;
                e.ReplaceAccumulatedForce(new Vector2(normalizedForce.x * e.maxForce.value, normalizedForce.y * e.maxForce.value));
            }
        }
    }
}