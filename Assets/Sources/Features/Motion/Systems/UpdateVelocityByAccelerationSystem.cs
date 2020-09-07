using Entitas;
using UnityEngine;

public sealed class UpdateVelocityByAccelerationSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public UpdateVelocityByAccelerationSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Velocity, SimMatcher.Acceleration));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            e.ReplaceVelocity(new Vector2(e.velocity.value.x + e.acceleration.value.x * Time.deltaTime, e.velocity.value.y + e.acceleration.value.y * Time.deltaTime));
        }
    }
}