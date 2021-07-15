using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plant : MonoBehaviour
{
    public GameObject plant;
    public GameObject sprout;
    public GameObject leaf;
    public GameObject leaf1;
    public GameObject leaf2;
    public GameObject leaf3;

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
            plant.SetActive(true);
            sprout.SetActive(false);
            Destroy(leaf, 1f);
            Destroy(leaf1, 1f);
            Destroy(leaf2, 1f);
            Destroy(leaf3, 1f);
        }
    }

}
