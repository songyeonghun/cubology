using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameObj : MonoBehaviour
{
    public int onoff;
    float onDelay=0.2f, timer=0;
    public GameObject fire1, fire2, fire3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (onDelay < timer&&collision.gameObject.tag == "Spark")
        {
            onoff++; timer = 0;
        }
        if (onoff % 2 == 0)
        {
            fire1.SetActive(false);
            fire2.SetActive(false);
            fire3.SetActive(false);
            timer = 0;
        }
        else
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            fire3.SetActive(true);
            timer = 0;
        }
    }
}
