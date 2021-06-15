using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour
{
    public GameObject[] g;
    GameObject tmp;
    void OnTriggerEnter2D(Collider2D other)
    {
        //tmp = GameObject.Instantiate(g[0]);
        //tmp.transform.position = transform.position;
    }
}
