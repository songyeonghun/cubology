using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeverObj : MonoBehaviour
{
    public int onoff;
    public GameObject Leverspark;
    public GameObject Leverspark1;
    public GameObject Leverspark2;
    public GameObject Leverspark3;
    public Sprite off;
    public Sprite on;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onoff++;
        }
        if (onoff % 2 == 0)
        {
            audioSource.Stop();
            Leverspark.SetActive(false);
            Leverspark1.SetActive(false);
            Leverspark2.SetActive(false);
            Leverspark3.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = off;
        }
        else
        {
            audioSource.Play();
            Leverspark.SetActive(true);
            Leverspark1.SetActive(true);
            Leverspark2.SetActive(true);
            Leverspark3.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = on;
        }
    }
}
