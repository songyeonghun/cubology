using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject Sspark;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Fire")
        {
                Sspark.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy"|| collision.gameObject.tag == "Fire")
        {
                Sspark.SetActive(false);
        }
    }
}
