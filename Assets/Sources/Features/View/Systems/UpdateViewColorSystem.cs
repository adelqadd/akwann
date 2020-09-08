using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class UpdateViewColorSystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public UpdateViewColorSystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.AllOf(SimMatcher.Color));
    }

    protected override bool Filter(SimEntity entity) {
        return entity.hasColor && entity.hasSpriteRenderer;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            e.spriteRenderer.value.color = e.color.value;
        }
    }
}