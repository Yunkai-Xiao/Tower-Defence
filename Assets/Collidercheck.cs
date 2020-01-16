using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidercheck : MonoBehaviour {
    private int collnum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemybullet(Clone)")
        {
            collnum++;
            Debug.Log(collnum);
            if (collnum >= 20)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
