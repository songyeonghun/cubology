using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class segwayX : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rbody;
    public Sprite segwayright;
    public Sprite segwayleft;
    int distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector3(speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            speed = -speed;
            if (collision.gameObject.tag == "Wall" && collision.gameObject.tag != "Enemy")
            {
                distance++;
            }
            if (distance % 2 == 0)
            {
                GetComponent<SpriteRenderer>().sprite = segwayright;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = segwayleft;
            }
    }
}
