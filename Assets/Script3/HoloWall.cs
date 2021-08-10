using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloWall : MonoBehaviour
{
    public Sprite on, off;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Spark")
        {
            if (gameObject.layer == 21)
            {
                audioSource.Stop();
                gameObject.layer = 22;
                GetComponent<SpriteRenderer>().sprite = off;
            }
            else
            {
                audioSource.Play();
                GetComponent<SpriteRenderer>().sprite = on;
                gameObject.layer = 21;
            }
        }
    }
}
