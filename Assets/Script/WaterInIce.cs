using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInIce : MonoBehaviour
{
    public GameObject ice,Acid;
    int number;
    // Start is called before the first frame update
    void Start()
    {
        number = WaterPumpObj.number;
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
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "iceleaf")
        {
            Instantiate(ice, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Poison")
        {
            Instantiate(Acid, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }

}
