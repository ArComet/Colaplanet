using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildBoarMove : MonoBehaviour
{
    public float speed = 3f;
    public float chargeSpeed = 3f;
    public float chargeTime = 2f;
    public GameObject effect;
    private int state = 1;
    private float timer = 0;
    private GameObject player;
    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("player");
    }
    void FixedUpdate()
    {
        timer = Mathf.Max(0, timer - Time.deltaTime);
        if (timer == 0)
        {
            timer += chargeTime;
            state = 1 - state;
        }
        if (player == null)
            return;
        Vector2 v = (player.transform.position - transform.position).normalized;
        if (state == 1)
        {
            v.x *= chargeSpeed;
            v.y *= chargeSpeed;
            effect.SetActive(true);
        }
        else
        {
            effect.SetActive(false);
        }
        if (v.x == 0 && v.y == 0)
        {
            animator.SetInteger("state", 0);
        }
        else
        {
            animator.SetInteger("state", 1);
        }
        if (v.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (v.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (GetComponent<HitControl>().isHit())
            effect.SetActive(false); 
        if (!GetComponent<HitControl>().isHit())
            transform.Translate(new Vector2(v.x * speed * Time.deltaTime, v.y * speed * Time.deltaTime));
    }
}
