using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soil : MonoBehaviour
{
    public Sprite sprout;
    public Sprite plant;
    public Sprite snowplant;

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
        if (collision.gameObject.tag == "seed")
        {
            GetComponent<SpriteRenderer>().sprite = sprout;

<<<<<<< HEAD
=======
        if (grow == true)
        { 
      
>>>>>>> 897654d7da5fc0927618b3cdd93e6844b9a3b013
            if (collision.gameObject.tag == "Water")
            {
                GetComponent<SpriteRenderer>().sprite = plant;

            }

            if (collision.gameObject.tag == "IceGas")
            {
                GetComponent<SpriteRenderer>().sprite = snowplant;

            }

        }  
    }
}