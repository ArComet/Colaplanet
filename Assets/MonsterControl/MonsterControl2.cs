using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl2 : MonoBehaviour
{
    public GameObject[] g;
    GameObject tmp;

    void OnTriggerEnter2D(Collider2D other)
    {
        tmp = GameObject.Instantiate(g[0]);
        tmp.transform.position = transform.position+new Vector3(10,0,0);
        Destroy(this.gameObject);
    }
}
