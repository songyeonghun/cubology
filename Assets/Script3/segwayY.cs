using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class segwayY : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rbody;
    public Sprite segwayup;
    public Sprite segwaydown;
    int distance = 0;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbody.velocity = new Vector3(0, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
        if (collision.gameObject.tag == "Wall" && collision.gameObject.tag!="Enemy" && collision.gameObject.tag!="Sensor")
        {
            distance++;
        }
        if (distance % 2 == 0)
        {
            GetComponent<SpriteRenderer>().sprite = segwayup;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = segwaydown;
        }

    }
}
