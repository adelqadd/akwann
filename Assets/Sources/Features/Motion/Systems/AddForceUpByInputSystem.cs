using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class AddForceUpByInputSystem: ReactiveSystem<InputEntity> {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;

    public AddForceUpByInputSystem(Contexts contexts) : base(contexts.input) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.Forces);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) {
        return context.CreateCollector(InputMatcher.ForceUpInput.Added());
    }

    protected override bool Filter(InputEntity entity) {
        return entity.isForceUpInput;
    }
    
    protected override void Execute(List<InputEntity> inputs) {
        foreach (InputEntity i in inputs) {
            foreach (SimEntity e in _entities.GetEntities()) {
                List<Vector2> forces = e.forces.value;
                forces.Add(Vector2.up * 5);
                e.ReplaceForces(forces);
            }
        }
    }
}