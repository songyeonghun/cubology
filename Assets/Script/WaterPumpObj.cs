using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPumpObj : MonoBehaviour
{
    public GameObject fire1;
    public int onoff = 0, way = 0;
    public static int number=0;
    RaycastHit2D hit;
    void Start()
    {
        
    }

    void Update()
    {

        //ON�Ǹ� 
        if (onoff == 1|| onoff == 2)
        {
            //������ �������� ����(������Ʈ������ ���� X)
            switch (way)
            {
                case 0://������
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);break;
                case 1://����
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
                case 2://����
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x , transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity); break;
                case 3://�Ʒ���
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
            }
            onoff = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //���������϶� ����ʹ�����
        if (onoff == 1|| onoff==0&&collision.gameObject.tag == "Spark")
        {
            onoff++;
            number++;
        }
    }

}
