using UnityEngine;
using System.Collections;

public class TowerInstantiate : MonoBehaviour {
    public GameObject Tower;
    public GameObject iTower;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            if (GameObject.Find("iTower(Clone)") != null)
            {
                Destroy(GameObject.Find("iTower(Clone)"));
            }
            else 
            {
                InstantiateITower();
            }

        }
        if(Input.GetMouseButtonDown(0))
        {
            if (GameObject.Find("iTower(Clone)") != null)
            {
                Debug.Log(!GameObject.Find("iTower(Clone)").GetComponentInChildren<ChangeColor>().onCollision);
                if (!GameObject.Find("iTower(Clone)").GetComponentInChildren<ChangeColor>().onCollision)
                {
                    Instantiate(Tower, GameObject.Find("iTower(Clone)").transform.position, Quaternion.Euler(0, 0, 0));
                }
            }
        }
    }
    public void InstantiateITower()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.tag == "Ground")
            {
                Instantiate(iTower, hit.point, Quaternion.Euler(0, 0, 0));
                break;
            }

        }
        
    }
}
