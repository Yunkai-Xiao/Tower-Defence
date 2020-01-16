using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DetectEnemy : MonoBehaviour {
    public List<GameObject> enemyList;
    public List<GameObject> BulletList;
    void Start()
    {
        enemyList = new List<GameObject>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyList.Add(other.gameObject);
        }
        
    }
    void OnTriggerStay(Collider other)
    {
        if(!enemyList.Contains(other.gameObject))
        {
            if (other.gameObject.tag == "Enemy")
            {
                enemyList.Add(other.gameObject);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyList.Remove(other.gameObject);
        }
    }
}
