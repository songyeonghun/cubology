using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonObj : MonoBehaviour
{
    public int onoff = 0;
    float onDelay = 0.2f, timer = 0;
    public GameObject pistonbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (onoff % 2 == 0)
        {
            pistonbar.SetActive(false);
        }
        else
        {
            pistonbar.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (onDelay < timer && collision.gameObject.tag == "Spark")
        {
            onoff++;
            timer = 0;
        }
    }

}
