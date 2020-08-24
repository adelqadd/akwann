using Entitas;

public sealed class Systems : Feature {
    public Systems(Contexts contexts) : base("Systems") {
        Add(new TestSystem(contexts));
    }
}