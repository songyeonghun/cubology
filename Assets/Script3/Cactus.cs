using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public GameObject cactus;
    public GameObject Cactusboom;
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
        if (collision.gameObject.tag == "Fire" && collision.gameObject.tag == "Enemy")
        {
            cactus.SetActive(false);
            Cactusboom.SetActive(true);
        }

    }
}
