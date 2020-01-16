using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation1 : MonoBehaviour {
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
