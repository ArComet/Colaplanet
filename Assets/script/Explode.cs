using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject son;
    //爆炸特效
    public GameObject player;
    //玩家
    public float dis = 3f;
    //爆炸距离
    public float explodeTime = 1f;
    private float timer;
    //准备爆炸的时间
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
