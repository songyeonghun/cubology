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
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //물과 냉기가 만나면 냉기가 사라지고얼음 생성
        if (collision.gameObject.tag == "IceGas" || collision.gameObject.tag == "iceleaf")
        {

            audioSource.Play();
            Instantiate(ice, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Poison")
        {
            Destroy(gameObject);
            Instantiate(Acid, transform.position, Quaternion.identity);
        }

    }

}
