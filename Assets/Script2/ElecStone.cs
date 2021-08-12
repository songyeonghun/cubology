using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecStone : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Spark")
        {
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
