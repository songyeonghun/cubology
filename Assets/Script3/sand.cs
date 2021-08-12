using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Cactus;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "seed")
        {
            audioSource.Play();
            Sand.SetActive(false);
            Cactus.SetActive(true);
        }

    }
}