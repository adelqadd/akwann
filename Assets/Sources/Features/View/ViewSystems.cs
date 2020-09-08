using Entitas;

public sealed class ViewSystems : Feature {
    public ViewSystems(Contexts contexts) : base("View Systems") {
        Add(new AddViewToViewableEntitySystem(contexts));
        Add(new AddSpriteRendererBySpritePathSystem(contexts));
        Add(new UpdateViewColorSystem(contexts));
        Add(new UpdateViewPositionSystem(contexts));
        Add(new UpdateViewRotationSystem(contexts));
    }
}