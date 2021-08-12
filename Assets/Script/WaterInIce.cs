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

        //���� �ñⰡ ������ �ñⰡ ���������� ����
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
