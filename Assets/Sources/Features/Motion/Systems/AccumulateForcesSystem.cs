using Entitas;
using UnityEngine;

public sealed class AccumulateForcesSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;    
    private readonly IGroup<SimEntity> _entities;
    public AccumulateForcesSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.Forces));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            float forceX = 0;
            float forceY = 0;
            foreach(var f in e.forces.value) {
                forceX += f.x;
                forceY += f.y;
            }
            e.ReplaceAccumulatedForce(new Vector2(forceX, forceY));
        }
    }
}