using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonObj : MonoBehaviour
{
    public int onoff=0;
    public GameObject boll;
    public Transform bollSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //0²¨Áü 1ÄÑÁü 2´ë±â
        if (onoff == 1)
        {
            StartCoroutine(Cannonshot());
            onoff = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (onoff==0&&collision.gameObject.tag=="spark")
        {
            onoff = 1;
        }
    }

    IEnumerator Cannonshot()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(boll, bollSpawn);
        onoff = 1;
        
    }

}
