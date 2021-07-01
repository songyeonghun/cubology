using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonObj : MonoBehaviour
{
    public GameObject BulletPrefeb;
    public float delay = 2f,timer=0;
    public int onoff = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onoff>0)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                var bullet = Instantiate(BulletPrefeb, transform.position, Quaternion.identity).GetComponent<Bullet>();
                bullet.Fire(transform.right);
                timer = 0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            onoff = 1;
        }
    }

}
