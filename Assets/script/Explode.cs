using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject son;
    //��ը��Ч
    public GameObject player;
    //���
    public float dis = 3f;
    //��ը����
    public float explodeTime = 1f;
    private float timer;
    //׼����ը��ʱ��
    void Awake()
    {
        timer = explodeTime;
        son.GetComponent<ParticleSystem>().Pause();
        player = GameObject.FindGameObjectWithTag("player");
    }
    void FixedUpdate()
    {
        if (player == null) return;
        Vector2 d = transform.position-player.transform.position;
        if (d.magnitude <= dis)
        {
            GetComponent<MonsterMove>().enabled = false;
            if (timer > 0)
            {
                GetComponent<InvControl>().run(timer);
                timer = Mathf.Max(timer - Time.deltaTime, 0);
            }
            else
            {
                run();
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<MonsterMove>().enabled = true;
            timer = explodeTime;
        }
    }
    void run()
    {
        son.transform.parent = null;
        son.GetComponent<ParticleSystem>().Play();
        Destroy(this.gameObject);
    }
}
