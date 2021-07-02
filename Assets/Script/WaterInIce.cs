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

        //물과 냉기가 만나면 냉기가 사라지고얼음 생성
        if (collision.gameObject.tag == "IceGas")
        {
            Destroy(this.gameObject);
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        //플레이어말고 다른 오브젝트랑 닿으면 생성x
        else if(collision.gameObject.tag != "Player"&& collision.gameObject.tag != "Spark")
        {
            Destroy(this.gameObject);
        }
        
    }

}
