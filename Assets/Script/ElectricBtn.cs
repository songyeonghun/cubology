using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBtn : MonoBehaviour
{
    public GameObject spark, Onoff;
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
        if (collision.gameObject.tag == "Spark")
        {
            spark.SetActive(true); Onoff.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            spark.SetActive(false); Onoff.SetActive(false);
        }
    }

}
