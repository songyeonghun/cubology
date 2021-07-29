using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpobj : MonoBehaviour
{
    public GameObject Player;
    public int way = 1;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch(way)
            {
                case 1:
                    Player.transform.Translate(2, 0, 0);
                    break;
                case 2:
                    Player.transform.Translate(0, -2, 0);
                    break;
                case 3:
                    Player.transform.Translate(-2, 0, 0);
                    break;
                case 4:
                    Player.transform.Translate(0, 2, 0);
                    break;
            }
        }
    }

}
