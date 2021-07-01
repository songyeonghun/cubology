using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricObj : MonoBehaviour
{
    public GameObject spk;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SparkT());
    }

    IEnumerator SparkT()
    {
        yield return new WaitForSeconds(3f);
        spk.SetActive(true);
        StartCoroutine(SparkF());
    }
    IEnumerator SparkF()
    {
        yield return new WaitForSeconds(1f);
        spk.SetActive(false);
        StartCoroutine(SparkT());
    }

}
