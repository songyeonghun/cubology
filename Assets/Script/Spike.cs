using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    Material Material;
    public int onoff = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onoff == 1)
        {
            Material.color = Color.red;
            gameObject.tag = "Enemy";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (onoff == 0 && collision.gameObject.tag == "spark")
        {
            onoff = 1;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Material.color = Color.white;
        gameObject.tag = "Untagged";
        onoff = 0;
    }
}
