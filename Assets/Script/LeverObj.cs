using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverObj : MonoBehaviour
{
    public int onoff;
    public GameObject Leverspark;
    public GameObject Leverspark1;
    public GameObject Leverspark2;
    public GameObject Leverspark3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.tag == "Player")
        {
            onoff++;
        }
        if (onoff % 2 == 0)
        {
            Leverspark.SetActive(false);
            Leverspark1.SetActive(false);
            Leverspark2.SetActive(false);
            Leverspark3.SetActive(false);
        }
        else
        {
            Leverspark.SetActive(true);
            Leverspark1.SetActive(true);
            Leverspark2.SetActive(true);
            Leverspark3.SetActive(true);
        }
    }
}
