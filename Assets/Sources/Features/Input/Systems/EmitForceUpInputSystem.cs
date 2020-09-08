using Entitas;
using UnityEngine;

public sealed class EmitForceUpInputSystem: IExecuteSystem {
    private readonly Contexts _contexts;
    private readonly InputContext _inputContext;
    public EmitForceUpInputSystem(Contexts contexts) {
        _contexts = contexts;
        _inputContext = _contexts.input;
    }
    public void Execute() {
        if (Input.GetKeyDown(KeyCode.W)) {
            InputEntity e = _inputContext.CreateEntity();
            e.isForceUpInput = true;
        }
    }
}