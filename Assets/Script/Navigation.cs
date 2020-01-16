using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {


    public Transform target;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    private int targetnum;
    private Transform[] targetList = new Transform[4] ;
    public UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        targetList[0] = target;
        targetList[1] = target1;
        targetList[2] = target2;
        targetList[3] = target3;
        agent.SetDestination(target.position);

        targetnum = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (transform.position == targetList[targetnum].position)
        {
            if (targetnum != 3)
            {
                targetnum += 1;
                agent.SetDestination(targetList[targetnum].position);
            }
        }
	}
}
