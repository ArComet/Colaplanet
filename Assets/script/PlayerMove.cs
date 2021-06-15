using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public int state = 0;
    public Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        Vector2 v = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        v.x *= speed; v.y *= speed;
        if (v.x == 0 && v.y == 0)
        {
            animator.SetInteger("state", 0);
        }
        else
        {
            animator.SetInteger("state", 1);
        }
        if (v.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (v.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (!GetComponent<HitControl>().isHit())
            transform.Translate(new Vector2(v.x * Time.deltaTime, v.y * Time.deltaTime));
    }
}
