using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceObj : MonoBehaviour
{
    public GameObject icegas;
    public GameObject icegas1;
    public GameObject icegas2;
    public GameObject icegas3;
    public GameObject icegas4;
    public GameObject icegas5;
    public GameObject icegas6;
    public GameObject icegas7;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IceT());
    }

    IEnumerator IceT()
    {
        yield return new WaitForSeconds(4f);
        icegas.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas2.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas3.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas4.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas5.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas6.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        icegas7.SetActive(true);
        StartCoroutine(IceF());
    }

    IEnumerator IceF()
    {
        yield return new WaitForSeconds(2f);
        icegas.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas1.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas2.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas3.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas4.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas5.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas6.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        icegas7.SetActive(false);
        StartCoroutine(IceT());
    }

}