using Entitas;
using UnityEngine;

public sealed class UpdatePositionByVelocitySystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;

    public UpdatePositionByVelocitySystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Position, SimMatcher.Velocity));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            e.ReplacePosition(new Vector2(e.position.value.x + e.velocity.value.x * Time.deltaTime, e.position.value.y + e.velocity.value.y * Time.deltaTime));
        }
    }
}