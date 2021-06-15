using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMove : MonoBehaviour
{
    private float timer = 0;
    public int dir = 1;
    public float changeDirTime = 2f;
    public float speed = 1f;
    public float mxDis = 6f;
    public float mnDis = 3f;
    public GameObject player;
    Vector2 v;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }
    void FixedUpdate()
    {
        if (player == null) return;
        timer = Mathf.Max(0, timer - Time.deltaTime);
        if (timer == 0)
        {
            timer += changeDirTime;
            v=new Vector2(Random.Range(-1f, 1f),Random.Range(-1f, 1f)).normalized;
        }
        Vector2 d = transform.position - player.transform.position;
        if (d.magnitude >= mxDis)
        {
            v = (player.transform.position - transform.position).normalized;
        }
        else if(d.magnitude<=mnDis)
        {
            v = (player.transform.position - transform.position).normalized;
            v.x *= -1;v.y *= -1;
        }
        if (v.x > 0&&dir==1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(v.x<0&&dir==1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if(v.x > 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (v.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.Translate(new Vector2(v.x * speed * Time.deltaTime, v.y * speed * Time.deltaTime));
    }
}
