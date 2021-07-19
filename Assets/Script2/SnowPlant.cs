using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowPlant : MonoBehaviour
{
    public GameObject sprout;
    public GameObject snowplant;
    public GameObject iceleaf;
    public GameObject iceleaf1;
    public GameObject iceleaf2;
    public GameObject iceleaf3;
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
        if (collision.gameObject.tag == "IceGas")
        {
            sprout.SetActive(false);
            snowplant.SetActive(true);
            Destroy(iceleaf, 1f);
            Destroy(iceleaf1, 1f);
            Destroy(iceleaf2, 1f);
            Destroy(iceleaf3, 1f);
        }
    }
}
