using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    bool isFire=true;
    Vector3 direction;
    public float speed = 10f;
    public GameObject fireboll;

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
        if (collision.gameObject.tag == "Fire")
        {
            var bullet = Instantiate(fireboll, transform.position, Quaternion.identity).GetComponent<FireBulletObj>();
            bullet.Fire(direction);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
