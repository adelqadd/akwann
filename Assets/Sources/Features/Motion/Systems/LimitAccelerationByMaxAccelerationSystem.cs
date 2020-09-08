using Entitas;
using UnityEngine;

public sealed class LimitAccelerationByMaxAccelerationSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public LimitAccelerationByMaxAccelerationSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Acceleration, SimMatcher.MaxAcceleration));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            if (e.acceleration.value.magnitude >= e.maxAcceleration.value) {
                Vector2 normalizedAcceleration = e.acceleration.value.normalized;
                e.ReplaceAcceleration(new Vector2(normalizedAcceleration.x * e.maxAcceleration.value, normalizedAcceleration.y * e.maxAcceleration.value));
            }
        }
    }
}