using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPA : MonoBehaviour
{
    GameObject Player, TeleportB;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        TeleportB = GameObject.Find("TeleportB");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = TeleportB.transform.position;
        }
    }

}
