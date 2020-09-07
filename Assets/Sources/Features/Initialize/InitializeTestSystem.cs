using Entitas;
using UnityEngine;

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
        e.AddPosition(new Vector2(0, 0));
        e.AddVelocity(new Vector2(0, 0));
        e.AddAcceleration(new Vector2(0.1f, 0.1f));

        SimEntity ee = _simContext.CreateEntity();
        ee.isViewable = true;
        ee.AddSpritePath(SpritePaths.CircleDirection);
        ee.AddPosition(new Vector2(0, 0));
        ee.AddVelocity(new Vector2(0, 0));
        ee.AddAcceleration(new Vector2(-0.1f, 0.1f));
    }
}