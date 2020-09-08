using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class InitializeTestSystem: IInitializeSystem {
    private readonly Contexts _contexts;
    private readonly SimContext _simContext;
    public InitializeTestSystem(Contexts contexts) {
        _contexts = contexts;
        _simContext = _contexts.sim;
    }
    public void Initialize() {
        SimEntity e = _simContext.CreateEntity();
        e.isViewable = true;
        e.AddSpritePath(SpritePaths.CircleDirection);
        e.AddColor(new Color(1,0,0,1));

        e.AddRotation(0);

        e.AddPosition(new Vector2(0, 0));
        e.AddVelocity(new Vector2(0, 0));
        e.AddAcceleration(new Vector2(0, 0));

        e.AddMaxVelocity(1);
        e.AddMaxAcceleration(1);

        e.AddForces(new List<Vector2>());

        //e.AddGravityForce(new Vector2(0, -1));
        //e.AddWindForce(new Vector2(2, 0));
        //e.AddMass(10);
        //e.AddDragCoefficent(0.5f);
    }
}