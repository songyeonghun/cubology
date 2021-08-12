using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObj : MonoBehaviour
{
    public GameObject spike;

    //전류와 닿으면 스파이크나옴
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //전기와 닿으면 가시를 ON
        if (collision.gameObject.tag == "Spark")
        {
            spike.SetActive(true);
        }
    }

    //스파이크 들어감
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            StartCoroutine(SpikeOff());
        }
    }

    IEnumerator SpikeOff()
    {
        yield return new WaitForSeconds(0.2f);
        spike.SetActive(false);
    }

}
