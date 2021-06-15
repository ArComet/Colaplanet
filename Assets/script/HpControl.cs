using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpControl : MonoBehaviour
{
    public GameObject g;
    public int hp=5;
    public Slider hpSlider;
    void Awake()
    {
        hpSlider.maxValue = hp;
        hpSlider.value = hp;
    }
    public void run(int val)
    {
        hpSlider.value+=val;
        if (hpSlider.value <= 0)
        {
            if (tag == "player")
            {
                g.transform.parent = null;
            }
            Destroy(this.gameObject);
        }
    }
}
