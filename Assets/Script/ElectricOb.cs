using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricOb : MonoBehaviour
{
    public GameObject spk;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SparkT());
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator SparkT()
    {
        yield return new WaitForSeconds(3f);
        audioSource.Play();
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
