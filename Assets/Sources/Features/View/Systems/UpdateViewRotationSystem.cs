using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class UpdateViewRotationSystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public UpdateViewRotationSystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.Rotation);
    }

    protected override bool Filter(SimEntity entity) {
        return entity.hasView && entity.hasRotation;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            e.view.value.transform.localEulerAngles = new Vector3(0, 0, e.rotation.value);
        }
    }
}