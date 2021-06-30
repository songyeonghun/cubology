using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricObj : MonoBehaviour
{
    public GameObject spark;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SparkT());
    }

    IEnumerator SparkT()
    {
        yield return new WaitForSeconds(3f);
        spark.SetActive(true);
        StartCoroutine(SparkF());
    }
    IEnumerator SparkF()
    {
        yield return new WaitForSeconds(1f);
        spark.SetActive(false);
        StartCoroutine(SparkT());
    }

}