using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, -1, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, 1, 0);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(-1, 0 , 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(1, 0, 0);
        }
    }

    void FixedUpdate()
    {
        
    }

}
