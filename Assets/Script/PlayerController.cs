using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    private Vector3 movement;

    public float speedx;
    public float speedy;
    public float speedz;

    public float speedx1;
    public float speedy1;
    public float speedz1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");


        if (rb.transform.position.z <= 400)
        {
            if (rb.transform.position.x <= 120)
            {

                rb.velocity = new Vector3(speedx, speedy, speedz);
            }

            if (rb.transform.position.x >= 120)
            {
                rb.velocity = new Vector3(speedx, speedy, speedz * -1);
            }
        }
        
        

        if (rb.transform.position.z >= 400)
        {
            
            rb.velocity = new Vector3(speedx1, speedy1, speedz1);
            
        }



        
        //rb.AddForce(movement * speed,ForceMode.Impulse);
    }

}
