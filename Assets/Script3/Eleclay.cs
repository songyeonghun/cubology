using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eleclay : MonoBehaviour
{
    public GameObject laser;
    public GameObject eleclay;
    public GameObject elecston;
    float cubeDistance;
    int onoff = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
           
                cubeDistance = Vector3.Distance(eleclay.transform.position, elecston.transform.position);
                if (cubeDistance < 9)
                {
                    for (int i = 1; i - 1 < cubeDistance; i++)
                    {
                        Instantiate(laser, new Vector3(transform.position.x + i, transform.position.y, 0), Quaternion.identity);
                    }
                }
                else
                {
                    for (int i = 1; i < 9; i++)
                    {
                        Instantiate(laser, new Vector3(transform.position.x + i, transform.position.y, 0), Quaternion.identity);
                    }
                }
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(laser);
    }
}