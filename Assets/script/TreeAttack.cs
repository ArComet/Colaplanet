using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float attackTime = 1f;
    public float bulletSpeed = 5f;
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
            Vector2 dir2 = new Vector2(dir.x * Mathf.Cos(30 * Mathf.PI / 180) + dir.y * Mathf.Sin(30 * Mathf.PI / 180), -dir.x * Mathf.Sin(30 * Mathf.PI / 180) + dir.y * Mathf.Cos(30 * Mathf.PI / 180));
            tmp = GameObject.Instantiate(bullet);
            tmp.transform.position = transform.position;
            tmp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * (dir2.x), bulletSpeed * (dir2.y));
            Vector2 dir3 = new Vector2(dir.x * Mathf.Cos(-30 * Mathf.PI / 180) + dir.y * Mathf.Sin(-30 * Mathf.PI / 180), -dir.x * Mathf.Sin(-30 * Mathf.PI / 180) + dir.y * Mathf.Cos(-30 * Mathf.PI / 180));
            tmp = GameObject.Instantiate(bullet);
            tmp.transform.position = transform.position;
            tmp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * (dir3.x), bulletSpeed * (dir3.y));
            //tmp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * (dir.x), bulletSpeed * (dir.y)));
        }
    }
}
