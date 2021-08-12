using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonObj : MonoBehaviour
{
    public int onoff;
    float onDelay = 0.2f, timer = 0;
    public Sprite On, Off;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (onoff % 2 == 0)
        {
            audioSource1.Play();
            GetComponent<SpriteRenderer>().sprite = Off;
            GetComponent<BoxCollider2D>().size = new Vector2(0.9f, 0.9f);
            GetComponent<BoxCollider2D>().offset = new Vector2(0f, 0f);
        }
        else
        {
            audioSource2.Play();
            GetComponent<SpriteRenderer>().sprite = On;
            GetComponent<BoxCollider2D>().size = new Vector2(1.8f, 0.9f);
            GetComponent<BoxCollider2D>().offset = new Vector2(0.5f, 0f);
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
