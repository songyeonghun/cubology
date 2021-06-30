using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startposition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos;

        pos = this.gameObject.transform.position;

        Debug.Log(pos.x);
        Debug.Log(pos.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
