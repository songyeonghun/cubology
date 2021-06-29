using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObj : MonoBehaviour
{
    public int onoff = 0;
    public GameObject spike;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //�µǸ� ���ø� ������
        if (onoff == 1)
        {
            gameObject.tag = "Enemy";
        }
    }


    //������ ������ ������ũ����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //����� ������ ���ø� ON
        if (onoff == 0 && collision.gameObject.tag == "spark")
        {
            spike.SetActive(true);
            onoff = 1;
        }
    }

    //������ũ ��
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    spike.SetActive(false);
    //    gameObject.tag = "Untagged";
    //    onoff = 0;
    //}
}
