using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecCannon : MonoBehaviour
{
    bool isFire = true;
    Vector3 direction;
    public float speed = 8f;

    public void Fire(Vector3 dir)
    {
        direction = dir;
        isFire = true;
    }
    public void Start()
    {
        StartCoroutine(ElecReset());
    }
    void Update()
    {
        if (isFire)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
    IEnumerator ElecReset()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}
