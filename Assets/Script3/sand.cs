using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Cactus;

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
            Sand.SetActive(false);
            Cactus.SetActive(true);
        }

    }
}