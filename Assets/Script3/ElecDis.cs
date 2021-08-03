using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecDis : MonoBehaviour
{
    public GameObject elecball;
    public int way;
    Vector3 spawn;

    private void Update()
    {
        switch (way)
        {
            case 0: spawn = new Vector3(transform.position.x + 1, transform.position.y); break;
            case 1: spawn = new Vector3(transform.position.x - 1, transform.position.y); break;
            case 2: spawn = new Vector3(transform.position.x, transform.position.y + 1); break;
            case 3: spawn = new Vector3(transform.position.x, transform.position.y - 1); break;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Spark")
        {
            var bullet = Instantiate(elecball, spawn, Quaternion.identity).GetComponent<ElecCannon>();
            bullet.Fire(transform.right);
        }
    }
}
