using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInIce : MonoBehaviour
{
    public GameObject ice,Acid;
    int number;
    public AudioSource audioSource;

    void Start()
    {
        number = WaterPumpObj.number;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //물과 냉기가 만나면 냉기가 사라지고얼음 생성
        if (collision.gameObject.tag == "IceGas"|| collision.gameObject.tag == "iceleaf")
        {

            audioSource.Play();
<<<<<<< HEAD
            Instantiate(ice,transform.position, Quaternion.identity);
        }
=======
            Destroy(gameObject);
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "iceleaf")
        {

            audioSource.Play();
            Destroy(gameObject);
            Instantiate(ice, transform.position, Quaternion.identity);
        }
>>>>>>> 8d564a5a2231f85b8dd980ee4d6c13df8b042463
        else if (collision.gameObject.tag == "Poison")
        {
            Instantiate(Acid, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }

}
