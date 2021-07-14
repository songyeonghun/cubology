using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowPlant : MonoBehaviour
{
    public GameObject plant;
    public GameObject snowplant;
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
        if (collision.gameObject.tag == "IceGas")
        {
            plant.SetActive(false);
            snowplant.SetActive(true);
        }
    }
}
