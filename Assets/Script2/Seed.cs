using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seed : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 10f;


    public void Fire(Vector3 dir)
    {
        direction = dir;
        isFire = true;
    }

    void Update()
    {
        if (isFire)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "plant" && collision.gameObject.tag != "Spark" && collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
