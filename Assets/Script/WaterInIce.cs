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

        //���� �ñⰡ ������ �ñⰡ ���������� ����
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
        //�÷��̾�� �ٸ� ������Ʈ�� ������ ����x
        if (number != 1)
            Destroy(gameObject);
        if(number == 1 && collision.gameObject.tag != "Water")
            Destroy(gameObject);

    }

}
