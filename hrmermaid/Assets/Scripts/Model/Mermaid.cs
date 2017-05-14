using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermaid : GameEntity {

	public override float siteDepth { get { return 20f; } }
	public override float cruisinSpeed { get { return 20f; } }


	void Awake () {
		stateMachine = new StateMachine(this);
		steeringBehavior = new SteeringBehavoir(this, GameManager.MINBOUNDS, GameManager.MAXBOUNDS, 0f);
		stateMachine.SetCurrentState(MermaidTravelState.Instance);
		stateMachine.SetGlobalState(MermaidGlobalState.Instance);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		stateMachine.UpdateState();
		steeringBehavior.UpdateSteering();
	}
}
