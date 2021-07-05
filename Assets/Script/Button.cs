using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Buttonspark;
    public GameObject Buttonspark2;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(true);
            Buttonspark2.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(false);
            Buttonspark2.SetActive(false);
        }
    }
}
