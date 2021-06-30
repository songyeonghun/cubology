using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPumpObj : MonoBehaviour
{
    public GameObject fire1;
    public int onoff = 0, way = 0;
    RaycastHit2D hit;
    void Start()
    {
        
    }

    void Update()
    {

        //ON�Ǹ� 
        if (onoff == 1)
        {
            //������ �������� ����(������Ʈ������ ���� X)
            switch (way)
            {
                case 0://������
                    hit = Physics2D.Raycast(new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.TransformDirection(Vector2.right), 0.5f);
                    if (hit == true && hit.collider.name != "Spark") break;

                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);break;
                case 1://����
                    hit = Physics2D.Raycast(new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.TransformDirection(Vector2.left), 0.5f);
                    if (hit == true&&hit.collider.name!="Spark") break; 

                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
                case 2://����
                    hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.TransformDirection(Vector2.up), 0.5f);
                    if (hit == true && hit.collider.name != "Spark") break;

                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x , transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity); break;
                case 3://�Ʒ���
                    hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y -1f, transform.position.z), transform.TransformDirection(Vector2.down), 0.5f);
                    if (hit == true && hit.collider.name != "Spark") break;

                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
            }
            onoff = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //���������϶� ����ʹ�����
        if (onoff==0&&collision.gameObject.tag == "Spark")
        {
            onoff = 1;
        }
    }

}
