using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
    public Transform target;
    public GameObject bullet;
    public Transform bulletspawn;
    private int time;
    public int timespawn;

    private List<GameObject> towerList;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        
        time++;
        if (time == timespawn)
        {
            Vector3 relativePos = target.position - bulletspawn.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            bulletspawn.rotation = rotation;



            Instantiate(bullet, bulletspawn.position, bulletspawn.rotation);
            time = 0;
        }
        

	}

    
}
