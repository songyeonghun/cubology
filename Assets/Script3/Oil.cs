using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    public GameObject Fire;

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            Destroy(gameObject);
            Instantiate(Fire, new Vector3(transform.position.x+1, transform.position.y, 0), Quaternion.identity);
            Instantiate(Fire, new Vector3(transform.position.x-1, transform.position.y, 0), Quaternion.identity);
            Instantiate(Fire, new Vector3(transform.position.x, transform.position.y+1, 0), Quaternion.identity);
            Instantiate(Fire, new Vector3(transform.position.x, transform.position.y-1, 0), Quaternion.identity);
            Instantiate(Fire, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
    }
}
