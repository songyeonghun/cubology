using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObj : MonoBehaviour
{
    public GameObject spike;

    //������ ������ ������ũ����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //����� ������ ���ø� ON
        if (collision.gameObject.tag == "Spark")
        {
            spike.SetActive(true);
        }
    }

    //������ũ ��
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spark")
        {
            StartCoroutine(SpikeOff());
        }
    }

    IEnumerator SpikeOff()
    {
        yield return new WaitForSeconds(0.2f);
        spike.SetActive(false);
    }

}
