using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInIce : MonoBehaviour
{
    public GameObject ice,Acid;
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

        //���� �ñⰡ ������ �ñⰡ ���������� ����
        if (collision.gameObject.tag == "IceGas")
        {
<<<<<<< HEAD
            audioSource.Play();
            Destroy(gameObject);
=======
>>>>>>> fb9aea69df8ffff1569e45670944b3a4ccbd8470
            Instantiate(ice,transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "iceleaf")
        {
<<<<<<< HEAD
            audioSource.Play();
            Destroy(gameObject);
=======
>>>>>>> fb9aea69df8ffff1569e45670944b3a4ccbd8470
            Instantiate(ice, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Poison")
        {
            Instantiate(Acid, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }

}
