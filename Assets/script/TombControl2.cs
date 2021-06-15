using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombControl2 : MonoBehaviour
{
    public GameObject[] g;
    void Update()
    {
        bool flag = true;
        foreach (GameObject i in g)
        {
            if (i.GetComponent<SpriteRenderer>().enabled == false)
            {
                flag = false;
            }
        }
        if (flag)
        {
            Destroy(this.gameObject);
        }
    }
}
