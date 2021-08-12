using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStage : MonoBehaviour
{
    public GameObject Story;
    GameObject Spawn, Player;
    void Start()
    {

        Player = GameObject.Find("Player");
        Spawn = GameObject.Find("Spawn");
        PlayerSpawn();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Story.SetActive(true);
        }
    }
    void PlayerSpawn()
    {
        Player.transform.position = Spawn.transform.position;
    }
}
