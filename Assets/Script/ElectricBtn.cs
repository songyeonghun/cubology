using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBtn : MonoBehaviour
{
    public GameObject spark;
    public Sprite On, Off;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            spark.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = On;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            spark.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = Off;
        }
    }

}
