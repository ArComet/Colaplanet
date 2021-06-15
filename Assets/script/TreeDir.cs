using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDir : MonoBehaviour
{
    private GameObject player;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    void FixedUpdate()
    {
        if (player == null) return;
        if ((player.transform.position - transform.position).x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if ((player.transform.position - transform.position).x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
