using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planter : MonoBehaviour
{
    public Sprite planteron;
    public Sprite planterbrk;
    public GameObject SeedPrefeb, BullletSpawn, BullletSpawn1, BullletSpawn2;
    int work = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (work==0&&collision.gameObject.tag == "Spark")
        {
            GetComponent<SpriteRenderer>().sprite = planteron;
            var bullet = Instantiate(SeedPrefeb, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Seed>();
            bullet.Fire(transform.right);
            bullet = Instantiate(SeedPrefeb, BullletSpawn1.transform.position, Quaternion.identity).GetComponent<Seed>();
            bullet.Fire(transform.right);
            bullet = Instantiate(SeedPrefeb, BullletSpawn2.transform.position, Quaternion.identity).GetComponent<Seed>();
            bullet.Fire(transform.right);
            work=1;
            GetComponent<SpriteRenderer>().sprite = planterbrk;
        }
    }

}