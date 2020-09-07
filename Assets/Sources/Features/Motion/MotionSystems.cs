using Entitas;

public sealed class MotionSystems : Feature {
    public MotionSystems(Contexts contexts) : base("Motion Systems") {
        Add(new UpdatePositionByVelocitySystem(contexts));
        Add(new UpdateVelocityByAccelerationSystem(contexts));
    }
}