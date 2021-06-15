using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandInv : MonoBehaviour
{
    public float changeInvTime = 2f;
    public Color color;
    private float timer = 0;
    private float r = 1;
    
    void Awake()
    {
        color = GetComponent<SpriteRenderer>().color;
    }
    void FixedUpdate()
    {
        timer = Mathf.Max(0, timer - Time.deltaTime);
        if (timer == 0)
        {
            timer += changeInvTime;
            r = Random.Range(0f, 1f);
        }
        if (r>=0.5f)
        {
            color.a = 1f;
            GetComponent<SpriteRenderer>().color = color;
        }
        else
        {
            color.a = 0.2f;
            GetComponent<SpriteRenderer>().color = color;
        }
    }
}
