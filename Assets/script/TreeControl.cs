using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeControl : MonoBehaviour
{
    public GameObject g;
    public GameObject son;
    public float summonTime= 20f;
    private Slider hpSlider;
    private float timer = 0;
    private void Awake()
    {
        hpSlider = GetComponent<HpControl>().hpSlider;
        son.GetComponent<ParticleSystem>().Pause();
    }
    void FixedUpdate()
    {
        timer = Mathf.Max(0, timer - Time.deltaTime);
        if (hpSlider.value * 3 >= hpSlider.maxValue * 2)
        {

        }
        else if (hpSlider.value * 3 >= hpSlider.maxValue)
        {
            son.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            son.GetComponent<ParticleSystem>().Play();
        }
        if (timer == 0)
        {
            timer += summonTime;
            GameObject tmp = GameObject.Instantiate(g);
            tmp.transform.position = transform.position;
        }
    }
}
