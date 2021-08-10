using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Cactus;
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
        if (collision.gameObject.tag == "seed")
        {
            audioSource.Play();
            Sand.SetActive(false);
            Cactus.SetActive(true);
        }

    }
}