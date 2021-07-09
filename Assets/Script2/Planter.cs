using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planter : MonoBehaviour
{
    public GameObject SeedPrefeb, BullletSpawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            var bullet = Instantiate(SeedPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(transform.right);
            bullet = Instantiate(SeedPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(transform.right);
            bullet = Instantiate(SeedPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(transform.right);
        }
    }

}