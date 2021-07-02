using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameObj : MonoBehaviour
{
    public int onoff;
    public GameObject fire;
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
            onoff++;
        }
        if (onoff % 2 == 0)
        {
            fire.SetActive(false);
        }
        else fire.SetActive(true);
    }
}
