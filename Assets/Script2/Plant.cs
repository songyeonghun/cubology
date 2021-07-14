using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sprout : MonoBehaviour
{
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
