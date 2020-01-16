using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ShootBullet : MonoBehaviour {
    public GameObject bullet;
    public List<GameObject> enemyList;
    public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        DetectEnemy shoot = transform.parent.gameObject.GetComponentInChildren<DetectEnemy>();
        enemyList = shoot.enemyList;
        if(enemyList.Count>0)
        {
            Transform target = enemyList[0].transform;
            Vector3 relativePos = target.position -( transform.position+new Vector3(0f, height, 0f));
            Quaternion bulletRotation = Quaternion.LookRotation(relativePos, new Vector3(0, 1, 0));
            Instantiate(bullet,transform.position+new Vector3(0f,height,0f), bulletRotation);
        }

        
	}
}
