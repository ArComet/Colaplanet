using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject[] g1;
    public GameObject[] g2;
    public GameObject[] g3;
    public int state;
    void Awake()
    {
        state = 0;    
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        state = 1;
        foreach (GameObject g in g1)
        {
            if (g == null) continue;
            if (g.GetComponent<SpriteRenderer>().enabled == true)
            {
                g.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                g.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        foreach (GameObject g in g2)
        {
            if (g == null) continue;
            if (g.GetComponent<SpriteRenderer>().enabled == true)
            {
                g.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                g.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        foreach (GameObject g in g3)
        {
            if (g == null) continue;
            Destroy(g);
        }
    }
}
