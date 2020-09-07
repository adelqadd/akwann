using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class AddSpriteRendererBySpritePathSystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public AddSpriteRendererBySpritePathSystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.SpritePath);
    }

    protected override bool Filter(SimEntity entity) {
        return entity.hasSpritePath && !entity.hasSpriteRenderer;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            SpriteRenderer sp = e.view.value.AddComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>(e.spritePath.value);
            e.AddSpriteRenderer(sp);
        }
    }
}