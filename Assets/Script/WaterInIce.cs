using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInIce : MonoBehaviour
{
    public GameObject ice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //���� �ñⰡ ������ �ñⰡ ���������� ����
        if (collision.gameObject.tag == "IceGas")
        {
            Destroy(this.gameObject);
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        //�÷��̾�� �ٸ� ������Ʈ�� ������ ����x
        else if(collision.gameObject.tag != "Player"&& collision.gameObject.tag != "Spark")
        {
            Destroy(this.gameObject);
        }
        
    }

}
