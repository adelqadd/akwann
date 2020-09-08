using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class AddDragForceSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    private readonly IGroup<SimEntity> _entities;
    public AddDragForceSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
        _entities = _simContext.GetGroup(SimMatcher.AllOf(SimMatcher.DragCoefficent, SimMatcher.Forces, SimMatcher.Velocity));
    }
    public void Execute() {
        foreach (SimEntity e in _entities.GetEntities()) {
            float velocityMagnitude = e.velocity.value.magnitude;
            float dragMagnitude = e.dragCoefficent.value * velocityMagnitude * velocityMagnitude;

            Vector2 dragForce = new Vector2(e.velocity.value.x * -1, e.velocity.value.x * -1);
            Vector2 normarilizedDragForce = dragForce.normalized;
            dragForce = new Vector2(normarilizedDragForce.x * dragMagnitude, normarilizedDragForce.y * dragMagnitude);

            List<Vector2> forces = e.forces.value;
            forces.Add(dragForce);
            e.ReplaceForces(forces);
        }
    }
}