using Entitas;

public sealed class MotionSystems : Feature {
    public MotionSystems(Contexts contexts) : base("Motion Systems") {
        Add(new AddForcesComponentByAnyForceSystem(contexts));

        //TODO DELETE LATER
        Add(new AddForceUpByInputSystem(contexts));

        Add(new AddGravityForceSystem(contexts));
        Add(new AddWindForceSystem(contexts));
        Add(new AddDragForceSystem(contexts));

        Add(new AccumulateForcesSystem(contexts));
        Add(new UpdateAccumulatedForceByMassSystem(contexts));

        Add(new LimitAccumulatedForceByMaxForceSystem(contexts));
        Add(new UpdateAccelerationByAccumulatedForceSystem(contexts));

        Add(new LimitAccelerationByMaxAccelerationSystem(contexts));
        Add(new UpdateVelocityByAccelerationSystem(contexts));
        
        Add(new LimitVelocityByMaxVelocitySystem(contexts));
        Add(new UpdatePositionByVelocitySystem(contexts));

        Add(new ClearForcesListSystem(contexts));
    }
}