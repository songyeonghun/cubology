using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObj : MonoBehaviour
{
    public int onoff = 0;
    public GameObject spike;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //온되면 가시를 적판정
        if (onoff == 1)
        {
            gameObject.tag = "Enemy";
        }
    }


    //전류와 닿으면 스파이크나옴
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //전기와 닿으면 가시를 ON
        if (onoff == 0 && collision.gameObject.tag == "spark")
        {
            spike.SetActive(true);
            onoff = 1;
        }
    }

    //스파이크 들어감
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    spike.SetActive(false);
    //    gameObject.tag = "Untagged";
    //    onoff = 0;
    //}
}
