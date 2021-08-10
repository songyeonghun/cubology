using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishObj : MonoBehaviour
{
    GameObject Spawn, Player;
    public string nextstage;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Spawn = GameObject.Find("Spawn");
        PlayerSpawn();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("nextStage");
            SceneManager.LoadScene(nextstage);
        }
    }

    void PlayerSpawn()
    {
        Player.transform.position = Spawn.transform.position;
    }
}
