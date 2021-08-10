using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilDis : MonoBehaviour
{
    public GameObject Oil;
    public int way;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //오프일떄 전기와 닿으면
        if (collision.gameObject.tag == "Spark")
        {
            switch (way)
            {
                case 0://오른쪽
                    Instantiate(Oil, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.identity); break;
                case 1://왼쪽
                    Instantiate(Oil, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x - 2, transform.position.y, 0), Quaternion.identity); break;
                case 2://위쪽
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y + 2, 0), Quaternion.identity); break;
                case 3://아래쪽
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(Oil, new Vector3(transform.position.x, transform.position.y - 2, 0), Quaternion.identity); break;
            }
        }
    }
}
