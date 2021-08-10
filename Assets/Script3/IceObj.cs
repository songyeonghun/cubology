using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceObj : MonoBehaviour
{
    public GameObject icegas;

    void Start()
    {
        StartCoroutine(IceT());
    }

    IEnumerator IceT()
    {
        yield return new WaitForSeconds(6f);
        StartCoroutine(IceT());
        Instantiate(icegas, new Vector3(transform.position.x - 1,transform.position.y + 1,0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x, transform.position.y + 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x , transform.position.y - 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Instantiate(icegas, new Vector3(transform.position.x - 1, transform.position.y , 0), Quaternion.identity);

    }



}