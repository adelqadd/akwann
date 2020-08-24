using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Entitas;
using UnityEngine;

public class SimController : MonoBehaviour {

	private Contexts _contexts;
    private Systems _systems;

	private void Awake () {
		_contexts = Contexts.sharedInstance;
		_systems = new Systems(_contexts);
		_systems.Initialize();
	}

	private void Update() {
		_systems.Execute();
		_systems.Cleanup();
	}

	private void OnDestroy() {
		_systems.TearDown();
	}
}