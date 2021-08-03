using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Buttonspark;
    public Sprite On,Off;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = On;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Buttonspark.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = Off;
        }
    }
}
