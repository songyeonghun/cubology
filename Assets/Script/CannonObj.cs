using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonObj : MonoBehaviour
{
    public GameObject BulletPrefeb,BullletSpawn;
    public float delay = 2f,timer=0,onDelay=0.2f;
    public int onoff = 0;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onoff%2==1)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                audioSource.Play();
                var bullet = Instantiate(BulletPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Bullet>();
                bullet.Fire(transform.right);
                timer = 0f;
            }
        }
        else timer = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            onoff++;
        }
    }

}
