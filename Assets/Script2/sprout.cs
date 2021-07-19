using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sprout : MonoBehaviour
{
    public GameObject plant;
    public GameObject sprout;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            plant.SetActive(true);
            sprout.SetActive(false);
        }
    }
}
