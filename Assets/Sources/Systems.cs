using Entitas;

public sealed class Systems : Feature {
    public Systems(Contexts contexts) : base("Systems") {
        Add(new InitializeTestSystem(contexts));

        Add(new MotionSystems(contexts));
        Add(new ViewSystems(contexts));
    }
}