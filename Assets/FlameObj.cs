using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameObj : MonoBehaviour
{
    public GameObject fire;
    public GameObject spark;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fire.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        fire.SetActive(false); 
    }
}