using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seed : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 10f;
    public AudioSource audioSource;


    public void Fire(Vector3 dir)
    {
        audioSource = GetComponent<AudioSource>();
        direction = dir;
        isFire = true;
    }

    void Update()
    {
        if (isFire)
        {
            audioSource.Play();
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="soil" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
