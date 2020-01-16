using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

    public Material normal, onCo;
    public bool onCollision;
    private bool colliding;
    void Start()
    {
        onCollision = false;
        colliding = false;
    }
    void Update()
    {
        if(transform .position.y!=12)
        {
            Disable();
        }
        else
        {
            if (!colliding)
            {
                Enable();
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Tower")
        {
            colliding = true;
            Disable();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag  == "Tower")
        {
            colliding = false;
            Enable();
        }
    }
    public void Enable()
    {
        onCollision = false;
        Material[] mats = mats = GetComponent<Renderer>().materials;
        mats[0] = normal;
        GetComponent<Renderer>().materials = mats;
    }
    public void Disable()
    {
        onCollision = true;
        Material[] mats = mats = GetComponent<Renderer>().materials;
        mats[0] = onCo;
        GetComponent<Renderer>().materials = mats;
    }
}
