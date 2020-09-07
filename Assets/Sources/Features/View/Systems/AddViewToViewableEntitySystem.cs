using Entitas;
using Entitas.Unity;
using System.Collections.Generic;
using UnityEngine;

public sealed class AddViewToViewableEntitySystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public AddViewToViewableEntitySystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.Viewable);
    }

    protected override bool Filter(SimEntity entity) {
        return entity.isViewable && !entity.hasView;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            GameObject gameObject = new GameObject("View");
            e.AddView(gameObject);

            gameObject.Link(e);
        }
    }
}