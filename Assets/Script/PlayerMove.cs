using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 goback;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (canMove==true&&Input.GetKeyDown("down"))
        {
            goback =new Vector3(transform.position.x,transform.position.y,0f);
            transform.Translate(0, -1, 0);
        }
        else if (canMove == true && Input.GetKeyDown("up"))
        {
           goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(0, 1, 0);
        }
        else if (canMove == true && Input.GetKeyDown("left"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(-1, 0 , 0);
        }
        else if (canMove == true && Input.GetKeyDown("right"))
        {
            goback = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.Translate(1, 0, 0);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Wall")
        {
            Debug.Log("goback");
            transform.position = goback;
        }
        else if(collision.gameObject.tag == "Stun")
        {
            canMove = false;
            StartCoroutine(nowStun());
        }
    }
    IEnumerator nowStun()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

}
