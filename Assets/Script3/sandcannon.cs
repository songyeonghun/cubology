using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandcannon : MonoBehaviour
{

    public GameObject SandPrefab, BullletSpawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            var bullet = Instantiate(SandPrefab, BullletSpawn.transform.position, Quaternion.identity).GetComponent<sandbullet>();
            bullet.Fire(transform.right);
        }
    }

}