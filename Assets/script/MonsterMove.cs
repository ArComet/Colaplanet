using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float speed = 0.2f;
    private GameObject player;
    private int dir=1;
    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("player");
    }
    void FixedUpdate()
    {
        if (player == null)
            return;
        Vector2 v = (player.transform.position-transform.position).normalized;
        v.x *= dir;v.y *= dir;
        if ((v.y >= v.x && v.y >= -v.x) || (-v.y >= v.x && -v.y >= -v.x))
        {
            if (v.y < 0)
            {
                animator.SetInteger("state", 0);
            }
            else if (v.y > 0)
            {
                animator.SetInteger("state", 1);
            }
        }
        if ((v.x >= v.y && v.x >= -v.y) || (-v.x >= v.y && -v.x >= -v.y))
        {
            if (v.x > 0)
            {
                animator.SetInteger("state", 2);
            }
            else if (v.x < 0)
            {
                animator.SetInteger("state", 3);
            }
        }
        if (!GetComponent<HitControl>().isHit())
            transform.Translate(new Vector2(v.x *speed* Time.deltaTime, v.y *speed* Time.deltaTime));
    }
}
