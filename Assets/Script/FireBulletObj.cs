using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletObj : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 10f;

    public void Fire(Vector3 dir)
    {
        direction = dir;
        isFire = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFire)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Wall")
        Destroy(gameObject);
       
    }

}
