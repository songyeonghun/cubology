using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonObj : MonoBehaviour
{
    public int onoff = 0;
    float onDelay = 0.2f, timer = 0;
    public Sprite On, Off;

    void Update()
    {
        timer += Time.deltaTime;
        if (onoff % 2 == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Off;
            GetComponent<BoxCollider2D>().size = new Vector2(0.9f, 0.9f);
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = On;
            GetComponent<BoxCollider2D>().size = new Vector2(1.8f, 0.9f);
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
