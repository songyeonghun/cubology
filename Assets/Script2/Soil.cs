using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soil : MonoBehaviour
{
    public Sprite sprout;
    public Sprite plant;
    bool grow = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "seed")
        {
            GetComponent<SpriteRenderer>().sprite = sprout;
            grow = true;
        }

        if (grow = true)
        { 
      
            if (collision.gameObject.tag = "Water")
            {
                GetComponent<SpriteRenderer>().sprite = plant;
            }
        }
    }
}