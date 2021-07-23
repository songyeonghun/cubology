using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand : MonoBehaviour
{
    public GameObject Sandtile;
    public GameObject sandcactus;

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
        if (collision.gameObject.tag == "seed")
        {
            Sandtile.SetActive(false);
            sandcactus.SetActive(true);
        }

    }
}