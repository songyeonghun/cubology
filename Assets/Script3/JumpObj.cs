using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpObj : MonoBehaviour
{
    public Sprite jump;
    public Sprite jump2;
    public Sprite jump3;
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
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().sprite = jump3;
            yield return new WaitForSeconds(0.3f);
            GetComponent<SpriteRenderer>().sprite = jump2;
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().sprite = jump;
        }
    
    }
}
