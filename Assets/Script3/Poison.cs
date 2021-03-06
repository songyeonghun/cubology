using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 5f;

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
        Destroy(gameObject);
    }

}
