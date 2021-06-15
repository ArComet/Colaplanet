using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float destroyTime = 2f;
    //×Óµ¯´Ý»ÙÊ±¼ä
    void FixedUpdate()
    {
        /*destroyTime = Mathf.Max(destroyTime - Time.deltaTime, 0);
        if (destroyTime==0)
            Destroy(this.gameObject);*/
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.GetComponent<ColliderControl>()!=null && other.gameObject.GetComponent<ColliderControl>().timer > 0) return;
        //if (other.gameObject.GetComponent<RandInv>() != null && other.gameObject.GetComponent<RandInv>().color.a == 0.2f) return;
        Destroy(this.gameObject);
    }
    void OnParticleCollision(GameObject other)
    {
        //if (other.GetComponent<ColliderControl>()!=null&&other.GetComponent<ColliderControl>().timer > 0) return;
        //if (other.GetComponent<RandInv>() != null && other.GetComponent<RandInv>().color.a == 0.2f) return;
        Destroy(this.gameObject);
    }
}
