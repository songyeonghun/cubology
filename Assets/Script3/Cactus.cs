using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public GameObject cactus;
    public GameObject Cactusboom;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Poison")
        {
            cactus.SetActive(false);
            Instantiate(Cactusboom, transform.position, Quaternion.identity);
        }

    }
}
