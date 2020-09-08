using Entitas;
using System.Collections.Generic;

public sealed class UpdateAccumulatedForceByMassSystem: ReactiveSystem<SimEntity> {
    private readonly Contexts _contexts;

    public UpdateAccumulatedForceByMassSystem(Contexts contexts) : base(contexts.sim) {
        _contexts = contexts;
    }

    protected override ICollector<SimEntity> GetTrigger(IContext<SimEntity> context) {
        return context.CreateCollector(SimMatcher.AllOf(SimMatcher.AccumulatedForce));
    }

    protected override bool Filter(SimEntity entity) {
        return entity.hasMass && entity.hasAccumulatedForce;
    }
    protected override void Execute(List<SimEntity> entities) {
        foreach (var e in entities) {
            e.ReplaceAccumulatedForce(e.accumulatedForce.value / e.mass.value);
        }
    }
}