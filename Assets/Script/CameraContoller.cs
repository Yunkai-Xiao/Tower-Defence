using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour {

    public float speed;
    
    public Transform target;

	// Update is called once per frame
	void Update () {

        
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        target.position += new Vector3(Horizontal*speed, 0, Vertical* speed);

        if (Input.GetKey("z"))
        {
            target.position += new Vector3(0,1,0);
        }

        if (Input.GetKey("x"))
        {
            target.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKey("q"))
        {

            transform.Rotate(Vector3.up * 5, Space.World);


        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.down * 5, Space.World);
        }
        

        //transform.position = target.position + new Vector3(0,99,-180);
        
    }
}
