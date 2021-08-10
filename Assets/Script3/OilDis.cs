using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilDis : MonoBehaviour
{
    public GameObject Oil;
    public int way;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�����ϋ� ����� ������
        if (collision.gameObject.tag == "Spark")
        {
            switch (way)
            {
                case 0://������
                    Instantiate(Oil, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.identity); break;
                case 1://����
                    Instantiate(Oil, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x - 2, transform.position.y, 0), Quaternion.identity); break;
                case 2://����
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y + 2, 0), Quaternion.identity); break;
                case 3://�Ʒ���
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y - 2, 0), Quaternion.identity); break;
            }
        }
    }
}
