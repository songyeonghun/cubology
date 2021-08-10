using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Buttonspark;
    public Sprite On,Off;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            Buttonspark.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = On;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Stop();
            Buttonspark.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = Off;
        }
    }
}
