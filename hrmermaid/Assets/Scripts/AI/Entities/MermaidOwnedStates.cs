using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermaidGlobalState : State
{
	private static MermaidGlobalState instance;
	private MermaidGlobalState(){}
	public static MermaidGlobalState Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new MermaidGlobalState();
			}
			return instance;
		}
	}//this is a singleton

	public override void Enter(GameEntity mermaid)
	{
	}

	public override void Execute(GameEntity mermaid)
	{
//		Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
//		float disToPlayer = Vector3.Distance(mermaid.transform.position,playerPos);
//		float angleToPlayer = Vector3.Angle(playerPos - mermaid.transform.localPosition, mermaid.transform.forward);
	}

	public override void Exit(GameEntity mermaid)
	{}
};


public class MermaidTravelState : State
{
	private static MermaidTravelState instance;
	private MermaidTravelState(){}
	public static MermaidTravelState Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new MermaidTravelState();
			}
			return instance;
		}
	}


	public override void Enter(GameEntity mermaid)
	{
		mermaid.GetSB ().SetSteering (SteeringBehavoir.Steering.Wander);
		mermaid.GetSB ().SetSpeed (mermaid.cruisinSpeed);
	}

	public override void Execute(GameEntity mermaid)
	{
	}

	public override void Exit(GameEntity mermaid)
	{
	}

}