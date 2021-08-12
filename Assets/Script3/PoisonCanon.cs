using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonCanon : MonoBehaviour
{
    public GameObject BulletPrefeb, BullletSpawn;
    public float delay = 4f, timer = 0, onDelay = 0.2f;
    public int onoff = 0;
    public AudioSource audioSource;
<<<<<<< HEAD
=======


>>>>>>> 098f26584d77c867828d36bbc67fa91c0a08e45a
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
<<<<<<< HEAD
=======


>>>>>>> 098f26584d77c867828d36bbc67fa91c0a08e45a
    void Update()
    {
        if (onoff % 2 == 1)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
<<<<<<< HEAD
                audioSource.Play();
                var bullet = Instantiate(BulletPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Poison>();
=======

                audioSource.Play();

                var bullet = Instantiate(BulletPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Poison>();

>>>>>>> 098f26584d77c867828d36bbc67fa91c0a08e45a
                bullet.Fire(transform.right);
                timer = 0f;
            }
        }
        else timer = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            onoff++;
        }
    }

}
