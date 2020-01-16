using UnityEngine;
using System.Collections;

public class ITowerFollow : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits=Physics.RaycastAll(ray);
        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.tag=="Ground")
            {

                float x = hit.point.x;
                float y = hit.collider.gameObject.transform.position.y+12;
                float z = hit.point.z;
                transform.position = new Vector3(x, y, z);
                
            }
            
        }
    }

}
