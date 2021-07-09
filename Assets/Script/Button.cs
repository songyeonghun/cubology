using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Buttonspark,BtnOn;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(true);
            BtnOn.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(false);
            BtnOn.SetActive(false);
        }
    }
}
