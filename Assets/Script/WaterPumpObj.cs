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

        //ON되면 
        if (onoff == 1|| onoff == 2)
        {
            //설정된 방향으로 생성(오브젝트있으면 생성 X)
            switch (way)
            {
                case 0://오른쪽
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);break;
                case 1://왼쪽
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
                case 2://위쪽
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x , transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y + 1, 0), Quaternion.identity); break;
                case 3://아래쪽
                    Instantiate(fire1, new Vector3(transform.position.x + 1, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(fire1, new Vector3(transform.position.x - 1, transform.position.y - 1, 0), Quaternion.identity); break;
            }
            onoff = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //오프상태일때 전기와닿으면
        if (onoff == 1|| onoff==0&&collision.gameObject.tag == "Spark")
        {
            onoff++;
            number++;
        }
    }

}
