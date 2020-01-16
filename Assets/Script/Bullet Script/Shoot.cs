using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {
    public float speed;
    private Rigidbody rd;
    private int time;
    public Rigidbody target;
    
	// Use this for initialization
	void Start () {
        time = 0;

        rd = GetComponent<Rigidbody>();
        this.rd.AddForce(this.transform.forward * speed, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
        time++;
        if(time>=120)
        {
            Destroy(this.gameObject);
        }

        

	}
}
