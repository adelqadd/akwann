using Entitas;
using UnityEngine;
using System.Collections.Generic;

[Sim]
public sealed class ForcesComponent : IComponent {
    public List<Vector2> value;
}