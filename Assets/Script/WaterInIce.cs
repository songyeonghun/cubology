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

        //���� �ñⰡ ������ �ñⰡ ���������� ����
        if (collision.gameObject.tag == "IceGas")
        {

            audioSource.Play();
            Destroy(gameObject);
<<<<<<< HEAD
=======

>>>>>>> 098f26584d77c867828d36bbc67fa91c0a08e45a
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "iceleaf")
        {
<<<<<<< HEAD
            audioSource.Play();
            Destroy(gameObject);
=======

            audioSource.Play();
            Destroy(gameObject);

>>>>>>> 098f26584d77c867828d36bbc67fa91c0a08e45a
            Instantiate(ice, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Poison")
        {
            Instantiate(Acid, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }

}
