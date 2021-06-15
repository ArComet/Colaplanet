using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl1 : MonoBehaviour
{
    public GameObject[] g;
    GameObject tmp;

    void OnTriggerEnter2D(Collider2D other)
    {
        tmp = GameObject.Instantiate(g[0]);
        tmp.transform.position = transform.position+new Vector3(8,1,0);
        tmp = GameObject.Instantiate(g[0]);
        tmp.transform.position = transform.position+new Vector3(8,-1,0);
        tmp = GameObject.Instantiate(g[1]);
        tmp.transform.position = transform.position+new Vector3(6,2,0);
        tmp = GameObject.Instantiate(g[1]);
        tmp.transform.position = transform.position+new Vector3(6,0,0);
        tmp = GameObject.Instantiate(g[1]);
        tmp.transform.position = transform.position+new Vector3(6,-2,0);
        tmp = GameObject.Instantiate(g[2]);
        tmp.transform.position = transform.position+new Vector3(10,-3,0);
        Destroy(this.gameObject);
    }
}
