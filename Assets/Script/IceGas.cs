using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceGas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(IceReset());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�ε����� ����
    void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }

    //2���� ����
    IEnumerator IceReset()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
