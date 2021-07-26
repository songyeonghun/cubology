using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    RaycastHit2D hit;
    public GameObject Sspark;
    void Start()
    {
        
    }

    void Update()
    {
        hit = Physics2D.Raycast(new Vector2(transform.position.x-0.5f,transform.position.y),Vector2.left,0.5f);

        if (hit == true)
        {
            Sspark.SetActive(true);
        }
        else Sspark.SetActive(false);
    }
}
