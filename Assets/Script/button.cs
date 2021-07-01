using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject Buttonspark;
    public GameObject Buttonspark2;

    private void Start()
    {
        Buttonspark.SetActive(false);
        Buttonspark2.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Buttonspark.SetActive(true);
        Buttonspark2.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Buttonspark.SetActive(false);
        Buttonspark2.SetActive(false);
    }
}

