using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInIce : MonoBehaviour
{
    public GameObject ice;
    int number;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        number = WaterPumpObj.number;
        audioSource = GetComponent<AudioSource>();
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
            audioSource.Play();
            Destroy(gameObject);
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "iceleaf")
        {
            audioSource.Play();
            Destroy(gameObject);
            Instantiate(ice, transform.position, Quaternion.identity);
        }
        //플레이어말고 다른 오브젝트랑 닿으면 생성x
        if (number != 1)
            Destroy(gameObject);
        if(number == 1 && collision.gameObject.tag != "Water")
            Destroy(gameObject);

    }

}
