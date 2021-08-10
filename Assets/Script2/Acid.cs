using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Acid : MonoBehaviour
{
    public GameObject Water;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="leaf")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "SandWater")
        {
            Instantiate(Water,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
