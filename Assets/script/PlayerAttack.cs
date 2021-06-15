using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timer = 0;
    public GameObject bullet;
    public float bulletSpeed = 3f;
    public float attackInterval = 0.5f;
    void Update()
    {
        if (Input.GetMouseButton(0)&&timer==0)
        {
            timer += attackInterval;
            GameObject tmp = GameObject.Instantiate(bullet);
            tmp.transform.position = transform.position;
            Vector2 di = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            Vector2 dir = new Vector2(di.x, di.y).normalized;
            tmp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * (dir.x), bulletSpeed * (dir.y));
            //tmp.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * (dir.x), bulletSpeed * (dir.y)));
        }
    }
    void FixedUpdate()
    {
        timer = Mathf.Max(timer - Time.deltaTime, 0);
    }
}
