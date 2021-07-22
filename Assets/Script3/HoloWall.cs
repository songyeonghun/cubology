using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloWall : MonoBehaviour
{
    public Sprite on,off;
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
        if(collision.gameObject.tag=="Spark")
        {
            if (gameObject.layer == 14)
            {
                gameObject.layer = 15;
                GetComponent<SpriteRenderer>().sprite = off;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = on;
                gameObject.layer = 14;
            }
        }
    }
}
