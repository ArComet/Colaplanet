using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    public float invincibleTime = 1;
    public float timer = 0;
    void FixedUpdate()
    {
        timer = Mathf.Max(timer - Time.deltaTime, 0);
        if(timer>0)
            GetComponent<InvControl>().run(timer);
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (timer > 0) return;
        if (GetComponent<RandInv>() != null && GetComponent<RandInv>().color.a == 0.2f) return;
        if (tag == "player" && other.gameObject.tag == "monster")
        {
            timer += invincibleTime;
            GetComponent<HpControl>().run(-1);
            GetComponent<HitControl>().run(other);
        }
        else if (tag == "monster" && other.gameObject.tag == "bullet")
        {
            timer += invincibleTime;
            GetComponent<HpControl>().run(-1);
            GetComponent<HitControl>().run(other);
        }
    }
    void OnParticleCollision(GameObject other)
    {
        if (timer > 0) return;
        if (GetComponent<RandInv>() != null && GetComponent<RandInv>().color.a == 0.2f) return;
            timer += invincibleTime;
        GetComponent<HpControl>().run(-1);
        if(GetComponent<HitControl>()!=null)
        GetComponent<HitControl>().run(other);
    }
}
