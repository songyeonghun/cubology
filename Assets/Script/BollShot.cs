using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollShot : MonoBehaviour
{
    public int way=0,speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //설정한 방향으로 볼 발사
        switch (way)
        {
            //설정한 방향으로 설정한 시간만큼 발사ㅣ
            case 0: transform.Translate(transform.right * Time.deltaTime* speed);break;
            case 1: transform.Translate(transform.right * -1 * Time.deltaTime * speed); break;
            case 2: transform.Translate(transform.up * Time.deltaTime * speed); break;
            case 3: transform.Translate(transform.up * -1 * Time.deltaTime * speed); break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //다른거와 닿으면 파괴
        Destroy(this.gameObject);
    }
}
