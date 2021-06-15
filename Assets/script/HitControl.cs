using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitControl : MonoBehaviour
{
    public float hitTime = 0.5f;
    public float hitSpeed = 4;
    private float timer = 0;
    private Vector2 v;
    void FixedUpdate()
    {
        timer = Mathf.Max(timer - Time.deltaTime, 0);
        if (timer > 0)
        {
            transform.Translate(new Vector2(v.x*Time.deltaTime,v.y*Time.deltaTime));
        }
    }
    public void run(Collision2D other)
    {
        timer += hitTime;
        v = (transform.position - other.transform.position).normalized;
        v.x *= hitSpeed;v.y *= hitSpeed;
    }
    public void run(GameObject other)
    {
        timer += hitTime;
        v = (transform.position - other.transform.position).normalized;
        v.x *= hitSpeed; v.y *= hitSpeed;
    }
    public bool isHit()
    {
        return timer > 0;
    }
}
