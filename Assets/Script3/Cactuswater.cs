using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactuswater : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 10f;
    public GameObject water;


    public void Fire(Vector3 dir)
    {
        direction = -dir;
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
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            Instantiate(water, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
    }
}
