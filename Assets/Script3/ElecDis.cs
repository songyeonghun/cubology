using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecDis : MonoBehaviour
{
    public GameObject elecball;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Spark")
        {
            var bullet = Instantiate(elecball, new Vector2(transform.position.x+1,transform.position.y), Quaternion.identity).GetComponent<ElecCannon>();
            bullet.Fire(transform.right);
        }
    }
}
