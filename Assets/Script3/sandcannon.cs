using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandcannon : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject SandPrefab, BullletSpawn;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            audioSource.Play();
            var bullet = Instantiate(SandPrefab, BullletSpawn.transform.position, Quaternion.identity).GetComponent<sandbullet>();
            bullet.Fire(transform.right);
        }
    }

}