using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSprayObj : MonoBehaviour
{
    public GameObject IceGas;
    public int onoff = 0, way = 0;
    RaycastHit2D hit;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //on되면
        if (onoff == 1)
        {
            audioSource.Play();
            //설정한 방향으로 생성
            switch (way)
            {
                case 0://오른쪽
                    hit = Physics2D.Raycast(new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.TransformDirection(Vector2.right), 0.5f);
                    if (hit == true && hit.collider.gameObject.tag =="Wall") break;

                    Instantiate(IceGas, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(IceGas, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.identity);break;
                case 1://왼쪽
                    hit = Physics2D.Raycast(new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.TransformDirection(Vector2.left), 0.5f);
                    if (hit == true && hit.collider.gameObject.tag == "Wall") break;

                    Instantiate(IceGas, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
                    Instantiate(IceGas, new Vector3(transform.position.x - 2, transform.position.y, 0), Quaternion.identity);break;
                case 2://위쪽
                    hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.TransformDirection(Vector2.up), 0.5f);
                    if (hit == true && hit.collider.gameObject.tag == "Wall") break;

                    Instantiate(IceGas, new Vector3(transform.position.x, transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(IceGas, new Vector3(transform.position.x, transform.position.y + 2, 0), Quaternion.identity);break;
                case 3://아래쪽
                    hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z), transform.TransformDirection(Vector2.down), 0.5f);
                    if (hit == true && hit.collider.gameObject.tag == "Wall") break;

                    Instantiate(IceGas, new Vector3(transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
                    Instantiate(IceGas, new Vector3(transform.position.x, transform.position.y - 2, 0), Quaternion.identity);break;
            }
            //한번만 생성하기위한 2
            onoff = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //오프일떄 전기와 닿으면
        if (onoff == 0 && collision.gameObject.tag == "Spark")
        {
            onoff = 1;
        }
    }

}
