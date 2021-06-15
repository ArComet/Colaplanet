using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float attackTime = 1f;
    public float bulletSpeed = 3f;
    private float timer = 0f;
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
            timer += attackTime;
            GameObject tmp = GameObject.Instantiate(bullet);
            tmp.transform.position = transform.position;
            Vector2 di = (player.transform.position - transform.position);
            Vector2 dir = new Vector2(di.x, di.y).normalized;
            tmp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * (dir.x), bulletSpeed * (dir.y));
            //tmp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * (dir.x), bulletSpeed * (dir.y)));
        }
    }
}
