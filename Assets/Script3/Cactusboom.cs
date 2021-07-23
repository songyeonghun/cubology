using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactusboom : MonoBehaviour
{
    public GameObject cactuswater, BullletSpawn, BullletSpawn1, BullletSpawn2, BullletSpawn3;
    // Start is called before the first frame update
    void Start()
    {
        var bullet = Instantiate(cactuswater, BullletSpawn3.transform.position, Quaternion.Euler(0,0,180)).GetComponent<Cactuswater>();
        bullet.Fire(transform.right);
        bullet = Instantiate(cactuswater, BullletSpawn.transform.position, Quaternion.identity).GetComponent<Cactuswater>();
        bullet.Fire(transform.right);
        bullet = Instantiate(cactuswater, BullletSpawn2.transform.position, Quaternion.Euler(0, 0, 90)).GetComponent<Cactuswater>();
        bullet.Fire(transform.right);
        bullet = Instantiate(cactuswater, BullletSpawn1.transform.position, Quaternion.Euler(0, 0, 270)).GetComponent<Cactuswater>();
        bullet.Fire(transform.right);
    }

}
