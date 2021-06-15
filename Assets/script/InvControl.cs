using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InvControl : MonoBehaviour
{
    public void run(float timer)
    {
        if (timer%0.3f<0.15f)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
