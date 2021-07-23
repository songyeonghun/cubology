using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus : MonoBehaviour
{
    public GameObject sandcactus;
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
        if (collision.gameObject.tag == "Fire")
        { 
            sandcactus.SetActive(false);
            Instantiate(Cactusboom, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            sandcactus.SetActive(false);
            Instantiate(Cactusboom, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
    }
}
