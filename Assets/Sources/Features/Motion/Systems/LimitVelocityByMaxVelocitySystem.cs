using Entitas;
using UnityEngine;

public sealed class LimitVelocityByMaxVelocitySystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public LimitVelocityByMaxVelocitySystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Velocity, SimMatcher.MaxVelocity));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            if (e.velocity.value.magnitude >= e.maxVelocity.value) {
                Vector2 normalizedVelocity = e.velocity.value.normalized;
                e.ReplaceVelocity(new Vector2(normalizedVelocity.x * e.maxVelocity.value, normalizedVelocity.y * e.maxVelocity.value));
            }
        }
    }
}