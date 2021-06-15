using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl2 : MonoBehaviour
{
    public GameObject[] g;

    void Update()
    {
        bool flag = true;
        foreach(GameObject i in g)
        {
            if (i.GetComponent<ButtonControl>().state == 0)
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
