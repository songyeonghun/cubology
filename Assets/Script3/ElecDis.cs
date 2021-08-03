using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecDis : MonoBehaviour
{
    public GameObject elecball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Spark")
        {
            var bullet = Instantiate(elecball, gameObject.transform.right, Quaternion.identity).GetComponent<ElecCannon>();
            bullet.Fire(transform.right);
        }
    }
}
