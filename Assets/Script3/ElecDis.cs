using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecDis : MonoBehaviour
{
    public GameObject BulletPrefeb, BullletSpawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            var bullet = Instantiate(BulletPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<ElecCannon>();
            bullet.Fire(transform.right);
        }
    }

}
