using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyStone : MonoBehaviour
{
    static public int Key;
    public int KeyCount;
    // Start is called before the first frame update
    void Start()
    {
        Key = KeyCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Key <= 0)
        {
            Destroy(gameObject);
        }
    }

}
