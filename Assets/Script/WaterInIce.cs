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
        else if (collision.gameObject.tag == "Poison")
        {
            Instantiate(Acid, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }

}
